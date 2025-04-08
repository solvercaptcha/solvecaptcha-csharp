using System;
using System.IO;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class CoordinatesOptionsExample
    {
        public CoordinatesOptionsExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            Coordinates captcha = new Coordinates();
            captcha.SetFile("resources/grid_2.jpg");
            captcha.SetLang("en");
            captcha.SetHintImg(new FileInfo("resources/grid_hint.jpg"));
            captcha.SetHintText("Select all images with an Orange");

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