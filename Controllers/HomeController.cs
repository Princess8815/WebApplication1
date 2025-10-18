using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CountVowels(string inputText)
        {
            int result = UtilityServices.CountVowels(inputText);
            ViewBag.VowelResult = $"Vowel count: {result}";
            return View("Index");
        }

        [HttpPost]
        public IActionResult CheckLeapYear(int year)
        {
            bool isLeap = UtilityServices.IsLeapYear(year);
            ViewBag.LeapResult = isLeap ? $"{year} is a leap year." : $"{year} is not a leap year.";
            return View("Index");
        }

        [HttpPost]
        public IActionResult CheckPalindrome(int number)
        {
            bool isPalindrome = UtilityServices.IsPalindrome(number);
            ViewBag.PalindromeResult = isPalindrome ? $"{number} is a palindrome." : $"{number} is not a palindrome.";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
