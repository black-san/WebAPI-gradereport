using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Classes
{
	public class returnMessage
	{
		public int code { get; set; }

		public string message { get; set; }
		public Object items { get; set; }

	}
}