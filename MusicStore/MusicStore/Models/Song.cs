using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
	public class Song
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Artist { get; set; }

		public byte Rate { get; set; }
		public string Url { get; set; }

	}
}