using Demo.Entities;
using Demo.Interfaces.Repositories;
using Framework.Business.Definitions;

namespace Demo.Business.Definitions
{
	public class AlbumBusiness : Business<Album, IAlbumRepository>
	{
	}
}
