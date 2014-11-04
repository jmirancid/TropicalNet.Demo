using System.ComponentModel.DataAnnotations;
using Demo.Entities.Resources;
using Framework.Entities;

namespace Demo.Entities
{
	[MetadataType(typeof(Album_Metadata))]
	public partial class Album : BaseEntity
	{
		public override int Id
		{
			get
			{
				return AlbumId;
			}
			set
			{
				AlbumId = value;
			}
		}
	}

	public class Album_Metadata
	{
		[Display(Name = "Entity_Title", ResourceType = typeof(Ent_AlbumResource))]
		[Required(ErrorMessageResourceName = "Val_Msg_Required", ErrorMessageResourceType = typeof(Ent_GlobalResource))]
		public string Title { get; set; }

		[Display(Name = "Entity_Artist", ResourceType = typeof(Ent_AlbumResource))]
		[Required(ErrorMessageResourceName = "Val_Msg_Required", ErrorMessageResourceType = typeof(Ent_GlobalResource))]
		public int ArtistId { get; set; }
	}
}
