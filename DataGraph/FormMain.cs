using QuikGraph;

namespace DataGraph
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();

			var graph = new AdjacencyGraph<Vertex, Edge>();
		}
	}
}
