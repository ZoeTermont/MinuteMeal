using Microsoft.AspNetCore.Mvc;
using MinuteMeal.ZoeTermont.Data;
using MinuteMeals.Models;

namespace MinuteMeal.ZoeTermont.Controllers
{
	public class RecipeController : Controller
	{
		private readonly MinuteMealData _context;

		public RecipeController(MinuteMealData context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var recipes = _context.Recipes.ToList();
			return View(recipes);
		}

		public IActionResult Details(int id)
		{
			var recipe = _context.Recipes.Find(id);
			if (recipe == null)
			{
				return NotFound();
			}
			return View(recipe);
		}
	}
}

