using Demo.Entities;
using Demo.Interfaces.Repositories;
using Framework.Business.Definitions;

namespace Demo.Business.Definitions
{
	public class ArtistBusiness : Business<Artist, IArtistRepository>
	{
	}
}
