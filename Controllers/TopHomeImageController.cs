using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VertoTest.Data;
using VertoTest.Models;
using VertoTest.Models.Entities;

namespace VertoTest.Controllers
{
    public class TopHomeImageController : Controller
    {
        private readonly VertoTestContext dbContext;

        public TopHomeImageController(VertoTestContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int Id { get; private set; }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(TopHomeImageTextModel viewModel)
        {
            var homeImage = new TopHomeImage
            {
                ImageTitle = viewModel.ImageTitle,
                ImageDescription = viewModel.ImageDescription
            };

            await dbContext.TopHomeImages.AddAsync(homeImage);
            await dbContext.SaveChangesAsync();


            var homeImageId = dbContext.TopHomeImages.FirstOrDefault(image => image.Id == Id);



            return RedirectToAction("Add");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var TopImage = await dbContext.TopHomeImages.ToListAsync();

            return View(TopImage);
        }
    }
}