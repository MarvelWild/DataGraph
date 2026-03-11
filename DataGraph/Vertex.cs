using MW.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DataGraph
{
	public class Vertex
	{
		[XmlAttributeAttribute("Name")]
        public string? Name { get; set; }

		[XmlAttributeAttribute("Description")]
		public string? Description{ get; set; }

		// not supported by GraphMLSerializer
		
		public DateTime DateTimeCreated { get; set; }

		
		public DateTime DateTimeModified { get; set; }


		//#region Serialization helpers

		//[XmlAttributeAttribute("DateTimeCreated1")]
		//public string DateTimeCreatedString {
		//	get { return DateTimeUtility.ToUtc(DateTimeCreated); }
		//	set { DateTimeCreated = DateTimeUtility.FromUtc(value); }
		//}

		//[XmlAttributeAttribute("DateTimeModified")]
		//public string DateTimeModifiedString
		//{
		//	get { return DateTimeUtility.ToUtc(DateTimeModified); }
		//	set { DateTimeModified = DateTimeUtility.FromUtc(value); }
		//}

		//#endregion


	}
}
