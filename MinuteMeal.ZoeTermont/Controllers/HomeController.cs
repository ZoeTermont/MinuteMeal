using Microsoft.AspNetCore.Mvc;
using MinuteMeal.ZoeTermont.Data;


namespace MinuteMeal.ZoeTermont.Controllers
{
	public class HomeController : Controller
    {
        
        private readonly MinuteMealData _context;

  
        public HomeController(ILogger<HomeController> logger, MinuteMealData context)
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