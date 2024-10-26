using Microsoft.EntityFrameworkCore;
using MinuteMeals.Models;

namespace MinuteMeal.ZoeTermont.Data
{
	public class MinuteMealData : DbContext
	{
		public MinuteMealData(DbContextOptions<MinuteMealData> options) : base(options) { }

		public DbSet<Recipe> Recipes => Set<Recipe>();

		public void Seed()
		{
			if (!Recipes.Any())
			{
				var recipes = new List<Recipe>
				{
					new Recipe { Name = "Spaghetti Bolognese", Ingredients = "Spaghetti, minced meat, tomatoes", Steps = "Boil water, prepare sauce...", CookingTimeInMinutes = 30 },
					new Recipe { Name = "Pancakes", Ingredients = "Flour, eggs, milk, sugar", Steps = "Mix ingredients, cook in pan...", CookingTimeInMinutes = 15 },
					new Recipe { Name = "Caesar Salad", Ingredients = "Lettuce, croutons, Caesar dressing", Steps = "Mix ingredients, serve...", CookingTimeInMinutes = 10 }
				};

				Recipes.AddRange(recipes);
				SaveChanges();
			}
		}
	}
}