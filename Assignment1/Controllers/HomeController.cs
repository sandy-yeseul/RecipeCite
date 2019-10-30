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
            //Recipe testRecipe = new Recipe()
            //{
            //    Name = "Chocolate Cake",
            //    Time = 130,
            //    Description = "A sweet chocolate cake",
            //    Ingredient = "chocolate"
            //};
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
                TempData["recipe"] = "Thank you for adding your recipe!";
                return View("ViewRecipe", recipe);
            }
            else
            {
                return View();
            }
        }
        public ViewResult RecipeList()
        {
            return View(Repository.Recipes);
        }
        [HttpGet]
        public ViewResult ReviewRecipe()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ReviewRecipe(Review review, string name)
        {
            if (ModelState.IsValid)
            {
                Recipe recipe = Repository.Recipes.FirstOrDefault(r => r.Name == name);
                review.RecipeName = recipe;

                Repository.AddReviews(review);
                return View( review);
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
    }
}
