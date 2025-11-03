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
        [HttpPost]
        public IActionResult CheckPalindrome(string inputValue)
        {
            if (string.IsNullOrWhiteSpace(inputValue))
            {
                ViewBag.PalindromeResult = "Please enter a value.";
                return View("Index");
            }

            bool isPalindrome;
            string typeDetected;

            // Detect if input is a pure number (integer)
            if (int.TryParse(inputValue, out int number))
            {
                typeDetected = "number";
                isPalindrome = UtilityServices.IsPalindrome(number);
            }
            else
            {
                typeDetected = "text";
                isPalindrome = UtilityServices.IsPalindrome(inputValue);
            }

            // Build a nice message for the user
            if (isPalindrome)
                ViewBag.PalindromeResult = $"The {typeDetected} \"{inputValue}\" is a palindrome!";
            else
                ViewBag.PalindromeResult = $"The {typeDetected} \"{inputValue}\" is not a palindrome.";

            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
