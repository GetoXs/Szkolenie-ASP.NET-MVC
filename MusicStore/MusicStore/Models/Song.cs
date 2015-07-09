using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
	public class Song
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[DisplayFormat(NullDisplayText="Anonymous")]
		public string Artist { get; set; }

		[Range(1, 5)]
		[Required]
		public byte Rate { get; set; }

		public string Url { get; set; }

	}
}