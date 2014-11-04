using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Demo.Business.Definitions;
using Demo.Entities;
using Framework.MVC.Controllers;

namespace Demo.WebSite.Controllers
{
	public class AlbumController :
		PersistanceController<Album, AlbumBusiness>
	{
		private readonly Lazy<ArtistBusiness> _bizArtist =
			new Lazy<ArtistBusiness>();

		public override ActionResult Index()
		{
			var albums =
				this.Business.Value.All().Include(a => a.Artist);

			return View(albums.ToList());
		}

		public override void CreateGetPrerender(Album entity = null)
		{
			ViewBag.ArtistId = new SelectList(this._bizArtist.Value.All(), "ArtistId", "Name");
		}

		public override void EditGetPrerender(Album entity)
		{
			ViewBag.ArtistId = new SelectList(this._bizArtist.Value.All(), "ArtistId", "Name", entity.ArtistId);
		}

		public override void DetailsGetPrerender(Album entity)
		{
			entity.Artist =
				this._bizArtist.Value.Get(entity.ArtistId);
		}

		public override void DeleteGetPrerender(Album entity)
		{
			DetailsGetPrerender(entity);
		}
	}
}