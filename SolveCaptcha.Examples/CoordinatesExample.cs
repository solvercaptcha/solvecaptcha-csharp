using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class CoordinatesExample
    {
        public CoordinatesExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            Coordinates captcha = new Coordinates("resources/grid.jpg");

            try
            {
                solver.Solve(captcha).Wait();
                Console.WriteLine("Captcha solved: " + captcha.Code);
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }
        }
    }
}