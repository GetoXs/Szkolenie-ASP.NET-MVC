using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class SongsController : Controller
	{
		static List<Song> Songs = new List<Song>()
							{
								new Song()
								{
									Id = 1,
									Name = "Baby",
									Artist = "Justin Bieber",
									Rate = 1,
									Url = "/App_Data/Songs/saewill_lo.mp3",
								},
								new Song()
								{
									Id = 2,
									Name = "Zegarmistrz światła purpurowy",
									Artist = "Tadeusz Woźniak",
									Rate = 4,
									Url = "/App_Data/Songs/tailtoddle_lo.mp3",
								},
								new Song()
								{
									Id = 3,
									Name = "Pink Floyd",
									Artist = "High Hopes",
									Rate = 5,
									Url = "/App_Data/Songs/Commercial DEMO - 11.mp3"
								},
							};



        // GET: Songs
        public ActionResult Index()
        {
			var model = Songs.OrderByDescending(s => s.Rate);

			ViewBag.Avg = model.Average(s => s.Rate);

			return View(model);
        }

		public ActionResult Download(int id)
		{
			var song = Songs.SingleOrDefault(s => s.Id == id);

			return File(song.Url, "audio/mpeg");
		}

		public ActionResult RateIt(int id, byte value)
		{
			var song = Songs.SingleOrDefault(s => s.Id == id);
			if(song != null)
				song.Rate = value;

			return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);

		}

        // GET: Songs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Songs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Songs/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Songs/Edit/5
        public ActionResult Edit(int id)
        {
			var song = Songs.SingleOrDefault(s => s.Id == id);


			return View(song);
        }

        // POST: Songs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
			var song = Songs.SingleOrDefault(s => s.Id == id);

			//aktualizacja wartości
			if (TryUpdateModel(song))
			{
				return RedirectToAction("Index");
			}

			return View(song);
        }

        // GET: Songs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Songs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
