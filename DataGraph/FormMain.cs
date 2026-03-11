using MW.Core;
using QuikGraph;
using QuikGraph.Algorithms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.ComponentModel;

namespace DataGraph
{
	public partial class FormMain : Form
	{

		public Vertex CreateVertex(string id)
		{
			return new Vertex() { Name = id };
		}

		public Edge CreateEdge(Vertex src, Vertex target, string id)
		{
			// (source, target, id) => new Edge<int>(source, target)
			return new Edge() { Source = src, Target = target};
		}

		public string SavePath { get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "graph.json"); ; } }

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public UndirectedGraph<Vertex, Edge> Graph { get; set; }

		public FormMain()
		{
			InitializeComponent();
			FormClosing += FormMain_FormClosing;

			Load();


		} // FormMain

		private void FormMain_FormClosing(object? sender, FormClosingEventArgs e)
		{
			Save();
		}

		private void Load()
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
		private void Save()
		{
			SerializableGraph sg = new SerializableGraph(Graph);


			var serialized = SerializationUtility.ToJson(sg);
			File.WriteAllText(SavePath, serialized);
		}

		/// <summary>
		/// Тут тестим новые фичи
		/// </summary>
		public void SandBox()
		{
			//var graph = new UndirectedGraph<Vertex, Edge>();

			//var root = new Vertex() { Name = "Root", Description = "Root desc 1", DateTimeCreated = DateTime.Now, DateTimeModified = DateTime.Now };

			//var gtnh = new Vertex() { Name = "Gtnh", Description = "Gt Desc", DateTimeCreated = DateTime.Now, DateTimeModified = DateTime.Now };
			//var gtnh1 = new Vertex() { Name = "Gtnh1", Description = "Gt Desc1", DateTimeCreated = DateTime.Now, DateTimeModified = DateTime.Now };

			//var edge = new Edge() { Source = root, Target = gtnh, Name = "Link 1", Description = "Link1 desc 1" };
			//var edge1 = new Edge() { Source = root, Target = gtnh1, Name = "Link 2", Description = "Link1 desc 2" };


			//graph.AddVerticesAndEdge(edge);
			//graph.AddVerticesAndEdge(edge1);

			//// Serialize to XML under the data directory
			//var outPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "graph.json");

			//SerializableGraph sg = new SerializableGraph(graph);


			//var serialized = SerializationUtility.ToJson(sg);
			//File.WriteAllText(outPath, serialized);

			//var graphDeserialized = SerializationUtility.FromJson<SerializableGraph>(serialized!);
			//var graph1 = graphDeserialized.CreateGraph();

		}
	}
}
