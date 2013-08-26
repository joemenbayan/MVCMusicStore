﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco" },
                new Genre { Name = "Senti" },
                new Genre { Name = "Romance" }
            };

            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre
            {
                Name = genre
            };
            
            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            var album = new Album 
            { 
                Title = "Album " + id 
            };

            return View(album);
        }

    }
}
