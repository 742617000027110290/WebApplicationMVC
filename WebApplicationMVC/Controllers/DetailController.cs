using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index(string id, string pageType)
        {
            var characters = new List<CharacterModel>()
            {
                new CharacterModel()
                {
                    Id = "Persian2",
                    Name = "Bontit",
                    Description = @"Bontit, Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                },
                new CharacterModel()
                {
                    Id = "Persian1",
                    Name = "Matting-gi",
                    Description = @"Matting-gi, Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                },
                new CharacterModel()
                {
                    Id = "BlackCat1",
                    Name = "Emong Ching",
                    Description = @"Emong Ching, Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                },
                new CharacterModel()
                {
                    Id = "Siamese1",
                    Name = "Ash",
                    Description = @"Ash, Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                },
                new CharacterModel()
                {
                    Id = "Persian4",
                    Name = "Storming-gi",
                    Description = @"Storming-gi, Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                }
            };

            var detail = characters.FirstOrDefault(c => c.Id == id);
            ViewBag.PageType = pageType;

            return View(detail);
        }
    }
}