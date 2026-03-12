using MW.Core;
using QuikGraph;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGraph
{
	public class MainController
	{
		private Vertex _currentVertex;

		public event EventHandler? CurrentVertexChanged;

		public UndirectedGraph<Vertex, Edge> Graph { get; set; }


		// todo: рутовую запретить удалять
		public Vertex CurrentVertex { get => _currentVertex; 
			set 
			{
				_currentVertex = value;
				CurrentVertexChanged?.Invoke(this, EventArgs.Empty);
			}
		}
		public Edge? CurrentEdge { get; set; }

		public string SavePath { get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "graph.json"); ; } }


		public MainController()
		{
			// не используется, создаётся повторно в Load()
			Graph = new UndirectedGraph<Vertex, Edge>();
			_currentVertex = new Vertex();
		}

		public void Load()
		{
			var savePath = SavePath;
			if (!File.Exists(savePath))
			{
				Graph = new UndirectedGraph<Vertex, Edge>();
				var rootVertex = new Vertex() { Name = "root1" };
				Graph.AddVertex(rootVertex);
				_currentVertex = rootVertex;
			}
			else
			{
				var serialized = File.ReadAllText(savePath);
				var sd = SerializationUtility.FromJson<SaveData>(serialized!);
				Graph = sd!.CreateGraph();
				_currentVertex = sd.CurrentVertex;
			}
		}

		// todo: вызывать на каждом изменении
		// todo opt: каждую ноду и грань в отдельный файл
		public void Save()
		{
			// todo: сериализовать current vertex
			SaveData sd = new SaveData(Graph);
			sd.CurrentVertex = CurrentVertex;



			var serialized = SerializationUtility.ToJson(sd);
			File.WriteAllText(SavePath, serialized);
		}

		public void CreateChildVertex()
		{
			// wip
			var newVertex = new Vertex();

			if (CurrentVertex != null)
			{
				var edge = new Edge() { Source = CurrentVertex, Target = newVertex};
				Graph.AddEdge(edge);
			}


			Graph.AddVertex(newVertex);
			CurrentVertex = newVertex;
		}
	} // MainController


}
