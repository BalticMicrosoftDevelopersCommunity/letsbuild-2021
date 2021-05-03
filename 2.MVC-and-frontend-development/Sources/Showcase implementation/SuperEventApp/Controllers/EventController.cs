using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SuperEventApp.Mappers;
using SuperEventApp.Models;
using SuperEventModels;
using SuperEventService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperEventApp.Controllers
{
    public class EventController : Controller
    {
        /// <summary>
        /// Participant registration screen
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Participant registration screen
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(ParticipantViewModel model)
        {
            if (ModelState.IsValid)
            {
                var participantLogic = new ParticipantLogic();
                participantLogic.AddParticipant(new Participant {Name = model.Name, Age = model.Age, Email = model.Email });
                return RedirectToAction("Participants");
            }

            return View();
        }

        /// <summary>
        /// Participant list
        /// </summary>
        /// <returns>View showing list of particpants</returns>
        public IActionResult Participants()
        {
            var participantLogic = new ParticipantLogic();
            var participantList = participantLogic.GetEventParticipants();
            List<ParticipantViewModel> participants = new List<ParticipantViewModel>();
            foreach (var item in participantList) {
                participants.Add(new ParticipantViewModel { Age = item.Age, Email = item.Email, Name = item.Name });
            }
            return View(participants);
        }
    }
}
