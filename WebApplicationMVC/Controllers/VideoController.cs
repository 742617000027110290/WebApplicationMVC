using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            var videos = new List<VideoModel>()
            {
                new VideoModel()
                {
                    Id = "Persian2",
                    Name = "Bontit",
                    Description = @"Bontit, Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    VideoURL = "https://www.youtube.com/embed/8t76rG9pE40"
                },
                new VideoModel()
                {
                    Id = "Persian1",
                    Name = "Matting-gi",
                    Description = @"Matting-gi, Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    VideoURL = "https://www.youtube.com/embed/JxS5E-kZc2s"
                },
                new VideoModel()
                {
                    Id = "Persian4",
                    Name = "Storming-gi",
                    Description = @"Storming-gi, Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    VideoURL = "https://www.youtube.com/embed/qoDgKmIGMr0"
                },
                new VideoModel()
                {
                    Id = "Siamese",
                    Name = "Ash",
                    Description = @"Ash, Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    VideoURL = "https://www.youtube.com/embed/KTIrTQahFSo"
                },
                new VideoModel()
                {
                    Id = "BlackCat1",
                    Name = "Emong-Ching",
                    Description = @"Emong-Ching, Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    VideoURL = "https://www.youtube.com/embed/2oRlBmwKzy4"
                }
            };
            return View(videos);
        }
    }
}
