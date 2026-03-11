using QuikGraph;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGraph
{
	public class Edge : IEdge<Vertex>
	{
		public string? Name;

		public required Vertex Source { get; set; }
		public required Vertex Target { get; set; }

	}
}
