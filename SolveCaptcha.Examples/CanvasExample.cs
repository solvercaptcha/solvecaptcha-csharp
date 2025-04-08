using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class CanvasExample
    {
        public CanvasExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            Canvas captcha = new Canvas();
            captcha.SetFile("resources/canvas.jpg");
            captcha.SetHintText("Draw around apple");

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