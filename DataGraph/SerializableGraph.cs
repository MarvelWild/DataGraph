using QuikGraph;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace DataGraph
{
	public class SerializableGraph
	{
		public List<Vertex> Vertices { get; set; }
		public List<Edge> Edges{ get; set; }

		// for deserialization
		public SerializableGraph()
		{
			Vertices = new List<Vertex>();
			Edges = new List<Edge>();
		}

		public SerializableGraph(UndirectedGraph<Vertex, Edge> graph)
		{
			Vertices = new List<Vertex>(graph.Vertices);
			Edges = new List<Edge>(graph.Edges);
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

