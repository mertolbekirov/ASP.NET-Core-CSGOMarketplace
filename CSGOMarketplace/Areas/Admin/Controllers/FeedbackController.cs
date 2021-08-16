﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGOMarketplace.Services.Feedback;
using Microsoft.AspNetCore.Mvc;

namespace CSGOMarketplace.Areas.Admin.Controllers
{
    public class FeedbackController : AdminController
    {
        private readonly IFeedbackService feedback;

        public FeedbackController(IFeedbackService feedback)
        {
            this.feedback = feedback;
        }

        public IActionResult AllFeedback()
        {
            var allFeedback = this.feedback
                .GetAll();

            return View(allFeedback);
        }

        public IActionResult Details(int id)
        {
            var feedbackInfo = this.feedback
                .GetById(id);
            if (feedbackInfo == null)
            {
                return BadRequest();
            }

            return View(feedbackInfo);
        }

    }
}
