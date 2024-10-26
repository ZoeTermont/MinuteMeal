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
					new Recipe { Name = "Caesar Salad", Ingredients = "Lettuce, croutons, Caesar dressing", Steps = "Mix ingredients, serve...", CookingTimeInMinutes = 10 },
					new Recipe { Name = "Vegetable Stir-fry", Ingredients = "Broccoli, bell peppers, soy sauce", Steps = "Stir-fry vegetables in a pan...", CookingTimeInMinutes = 20 },
					new Recipe { Name = "Chicken Curry", Ingredients = "Chicken, curry paste, coconut milk", Steps = "Cook chicken, add curry paste...", CookingTimeInMinutes = 25 },
					new Recipe { Name = "Beef Tacos", Ingredients = "Taco shells, ground beef, toppings", Steps = "Cook beef, assemble tacos...", CookingTimeInMinutes = 15 },
					new Recipe { Name = "Mushroom Risotto", Ingredients = "Arborio rice, mushrooms, broth", Steps = "Cook rice, add broth and mushrooms...", CookingTimeInMinutes = 30 },
					new Recipe { Name = "Fish and Chips", Ingredients = "Fish fillets, potatoes, batter", Steps = "Fry fish and chips...", CookingTimeInMinutes = 40 },
					new Recipe { Name = "Lentil Soup", Ingredients = "Lentils, carrots, celery", Steps = "Simmer lentils and vegetables...", CookingTimeInMinutes = 35 },
					new Recipe { Name = "Chocolate Cake", Ingredients = "Flour, sugar, cocoa, eggs", Steps = "Mix ingredients, bake...", CookingTimeInMinutes = 45 }

				};

				Recipes.AddRange(recipes);
				SaveChanges();
			}
		}
	}
}