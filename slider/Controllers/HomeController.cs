using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using slider.Data;
using slider.Models;
using slider.ViewModels;

namespace slider.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo slidersInfo = await _context.SliderInfos.FirstOrDefaultAsync();
            List<Category> categories = await _context.Categories.ToListAsync();
            List<Product> products = await _context.Products.Include(m => m.ProductImages).ToListAsync();
            AboutSuprise aboutSuprise = await _context.AboutSuprise.FirstOrDefaultAsync();
            SupriseText supriseText = await _context.SupriseTexts.FirstOrDefaultAsync();
            List<Expert> experts = await _context.Experts.ToListAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = slidersInfo,
                Categories = categories,
                Products = products,
                AboutSuprise = aboutSuprise,
                SupriseText = supriseText,
                Experts = experts
            };
            return View(model);
        }

    }
}
