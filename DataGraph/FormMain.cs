using MW.Core;
using QuikGraph;
using QuikGraph.Algorithms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

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

		public FormMain()
		{
			InitializeComponent();

			// todo: ненаправленнй граф
			var graph = new AdjacencyGraph<Vertex, Edge>();

			var root = new Vertex() { Name = "Root", Description = "Root desc 1", DateTimeCreated = DateTime.Now, DateTimeModified = DateTime.Now };

			var gtnh = new Vertex() { Name = "Gtnh", Description = "Gt Desc", DateTimeCreated = DateTime.Now, DateTimeModified = DateTime.Now };
			var gtnh1 = new Vertex() { Name = "Gtnh1", Description = "Gt Desc1", DateTimeCreated = DateTime.Now, DateTimeModified = DateTime.Now };

			var edge = new Edge() { Source = root, Target = gtnh, Name = "Link 1", Description = "Link1 desc 1" };
			var edge1 = new Edge() { Source = root, Target = gtnh1, Name = "Link 2", Description = "Link1 desc 2" };


			graph.AddVerticesAndEdge(edge);
			graph.AddVerticesAndEdge(edge1);

			// Serialize to XML under the data directory
			var outPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "graph.json");
			//var outPathXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "graph.xml");
			//using (var xmlWriter = XmlWriter.Create(outPath))
			//{
			//	graph.SerializeToGraphML<Vertex, Edge, AdjacencyGraph<Vertex, Edge>>(xmlWriter);
			//}

			//var graph1 = new AdjacencyGraph<Vertex, Edge>();
			//using (var xmlReader = XmlReader.Create(outPathXml))
			//{
			//	graph1.DeserializeFromGraphML<Vertex, Edge, AdjacencyGraph<Vertex, Edge>>(
			//		xmlReader,
			//		CreateVertex,
			//		CreateEdge);
			//}

			SerializableGraph sg = new SerializableGraph(graph);


			var serialized = SerializationUtility.ToJson(sg);
			File.WriteAllText(outPath, serialized);

			var graphDeserialized = SerializationUtility.FromJson<SerializableGraph>(serialized!);
			var graph1 = graphDeserialized.CreateGraph();



		} // FormMain
	}
}
