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
                Name = "Pizza",
                Time= 100,
                Description = "",
                Ingredients =""
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
        

        private static List<Review> reviews = new List<Review>();
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
