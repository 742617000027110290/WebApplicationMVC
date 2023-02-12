using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var featuredPosts = new List<FeaturedViewModel>
            {
                new FeaturedViewModel() {
                    Id = "Persian2",
                    Header = "Himalayan",
                    Title = "Bontit",
                    PostedDate = DateTime.Now,
                    Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec orci faucibus, dictum eros sit amet, tempor ipsum. Pellentesque ex nisl, pretium quis purus quis, ornare posuere lacus. Aenean lacinia dui tellus, non blandit magna rutrum sed. Ut a ipsum vitae nulla eleifend pharetra. Sed erat tortor, eleifend eget luctus ut, auctor quis lorem. Maecenas consequat fermentum neque, hendrerit placerat est. Aliquam elit est, pretium eu pharetra vel, commodo a lorem.",
                    ImageUrl = "Persian2.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Persian1",
                    Header = "Persian",
                    Title = "Matting-gi",
                    PostedDate = DateTime.Now,
                    Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec orci faucibus, dictum eros sit amet, tempor ipsum. Pellentesque ex nisl, pretium quis purus quis, ornare posuere lacus. Aenean lacinia dui tellus, non blandit magna rutrum sed. Ut a ipsum vitae nulla eleifend pharetra. Sed erat tortor, eleifend eget luctus ut, auctor quis lorem. Maecenas consequat fermentum neque, hendrerit placerat est. Aliquam elit est, pretium eu pharetra vel, commodo a lorem.",
                    ImageUrl = "Persian1.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Persian4",
                    Header = "Persian",
                    Title = "Storming-gi",
                    PostedDate = DateTime.Now,
                    Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec orci faucibus, dictum eros sit amet, tempor ipsum. Pellentesque ex nisl, pretium quis purus quis, ornare posuere lacus. Aenean lacinia dui tellus, non blandit magna rutrum sed. Ut a ipsum vitae nulla eleifend pharetra. Sed erat tortor, eleifend eget luctus ut, auctor quis lorem. Maecenas consequat fermentum neque, hendrerit placerat est. Aliquam elit est, pretium eu pharetra vel, commodo a lorem.",
                    ImageUrl = "Persian4.jpg"
                },
                new FeaturedViewModel() {
                    Id = "Siamese1",
                    Header = "Siamese",
                    Title = "Ash",
                    PostedDate = DateTime.Now,
                    Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec orci faucibus, dictum eros sit amet, tempor ipsum. Pellentesque ex nisl, pretium quis purus quis, ornare posuere lacus. Aenean lacinia dui tellus, non blandit magna rutrum sed. Ut a ipsum vitae nulla eleifend pharetra. Sed erat tortor, eleifend eget luctus ut, auctor quis lorem. Maecenas consequat fermentum neque, hendrerit placerat est. Aliquam elit est, pretium eu pharetra vel, commodo a lorem.",
                    ImageUrl = "Siamese1.jpg"
                }
            };

            return View(featuredPosts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }   
    }

    public class OtepController : Controller
    {
        public IActionResult Joseph()
        {
            return View();
        }
    }
}
