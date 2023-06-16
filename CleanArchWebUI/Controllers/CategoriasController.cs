using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchWebUI.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriasController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var vategories = await _categoryService.GetAll();
            return View(vategories);
        }
    }
}
