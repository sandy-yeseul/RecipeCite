using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class HomeController : Controller 
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRecipes(recipe);
                return View("ThankYouRecipe", recipe);
            }
            else
            {
                return View();
            }
        }
        public ViewResult RecipeList()
        {
            return View(Repository.Recipes.OrderBy(r => r.Name));
        }
        [HttpGet]
        public ViewResult AddReview(string name)
        {
            //Review review = new Review
            //{
            //    RecipeName = name
            //}
            //;
            return View(new Review { RecipeName = name});
        }
        [HttpPost]
        public ViewResult AddReview(Review review)
        {
            if (!(Repository.Recipes.Any( r => r.Name == review.RecipeName)))
            {
                ModelState.AddModelError("", "Reciepe doesn't exist");
            }
            if (ModelState.IsValid)
            {
                //Recipe recipe = Repository.Recipes.FirstOrDefault(r => r.Name == rvName);
                //review.RecipeName = recipe;

                Repository.AddReviews(review);
                //TempData["review"] = "Thank you for adding your review!";
                return View("ThankYouReview", review);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ViewRecipe( string name)
        {
            return View(Repository.Recipes.FirstOrDefault(r => r.Name == name));
        }
        public ViewResult ReviewList()
        {
            return View(Repository.Reviews);
        }
    }
}
