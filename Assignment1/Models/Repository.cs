using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Repository
    {
        private static List<Recipe> recipes = new List<Recipe>()
        {
            new Recipe()
            {
                Name = "American Pizza",
                Time= 100,
                Description = "American style pizza without pepperonies",
                Ingredients ="Pizaa dough, cheese"
            }
        };
        public static IEnumerable<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
        }
        public static void AddRecipes(Recipe recipe)
        {
            recipes.Add(recipe);
        }
        

        private static List<Review> reviews = new List<Review>()
        {
            new Review
            {
                RecipeName = "American Pizza",
                UserId = 1004,
                Nickname="Angel",
                Content="Delicious and warm"
            }
        };
        public static IEnumerable<Review> Reviews
        {
            get
            {
                return reviews;
            }
        }
        public static void AddReviews(Review review)
        {
            reviews.Add(review);
        }
    }
}
