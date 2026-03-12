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


		

		public MainController Controller = new MainController();

		public FormMain()
		{
			InitializeComponent();
			FormClosing += FormMain_FormClosing;

			Controller.Load();
			Controller.CurrentVertexChanged += Controller_CurrentVertexChanged;


		} // FormMain

		private void Controller_CurrentVertexChanged(object? sender, EventArgs e)
		{
			UpdateState();
		}

		private void FormMain_FormClosing(object? sender, FormClosingEventArgs e)
		{
			Controller.Save();
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

		private void FormMain_Load(object sender, EventArgs e)
		{
			UpdateState();
		}

		private void FormMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Insert)
			{
				Controller.CreateChildVertex();
			}
		}

		private void UpdateState()
		{
			UpdateCurrentVertex();
		}

		private void UpdateCurrentVertex()
		{
			var currentVertex = Controller.CurrentVertex;
			txtVertexName.Text = currentVertex.Name;
			txtVertexDescription.Text = currentVertex.Description;
		}
	}
}
