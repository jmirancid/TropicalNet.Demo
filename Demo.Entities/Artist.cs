using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Framework.Entities;

namespace Demo.Entities
{
	[MetadataType(typeof(Artist_Metadata))]
	public partial class Artist : BaseEntity
	{
		public override int Id
		{
			get
			{
				return ArtistId;
			}
			set
			{
				ArtistId = value;
			}
		}
	}

	public class Artist_Metadata
	{
		//[Display()]
		//public int AlbumId { get; set; }
	}
}
