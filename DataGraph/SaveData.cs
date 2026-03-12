using QuikGraph;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace DataGraph
{
	public class SaveData
	{
		public List<Vertex> Vertices { get; set; }
		public List<Edge> Edges { get; set; }


		public Vertex CurrentVertex { get; set; }

		// for deserialization
		public SaveData()
		{
			Vertices = new List<Vertex>();
			Edges = new List<Edge>();
			CurrentVertex = new Vertex();
		}

		public SaveData(UndirectedGraph<Vertex, Edge> graph)
		{
			Vertices = new List<Vertex>(graph.Vertices);
			Edges = new List<Edge>(graph.Edges);
			CurrentVertex = new Vertex();
		}

		public UndirectedGraph<Vertex, Edge> CreateGraph()
		{
			var result = new UndirectedGraph<Vertex, Edge>();

			result.AddVertexRange(Vertices);
			result.AddVerticesAndEdgeRange(Edges);

			return result;

		}
	}
}

