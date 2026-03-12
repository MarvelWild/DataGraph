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
			Graph = new UndirectedGraph<Vertex, Edge>();
			var rootVertex = new Vertex() { Name = "root1" };
			Graph.AddVertex(rootVertex);
			_currentVertex = rootVertex;
		}

		public void Load()
		{
			var savePath = SavePath;
			if (!File.Exists(savePath))
			{
				Graph = new UndirectedGraph<Vertex, Edge>();
			}
			else
			{
				var serialized = File.ReadAllText(savePath);
				var graphDeserialized = SerializationUtility.FromJson<SerializableGraph>(serialized!);
				Graph = graphDeserialized!.CreateGraph();
			}
		}

		// todo: вызывать на каждом изменении
		// todo opt: каждую ноду и грань в отдельный файл
		public void Save()
		{
			// todo: сериализовать current vertex
			SerializableGraph sg = new SerializableGraph(Graph);


			var serialized = SerializationUtility.ToJson(sg);
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
