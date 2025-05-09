using System;
using System.IO;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class CanvasBase64Example
    {
        public CanvasBase64Example(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            byte[] bytes = File.ReadAllBytes("resources/canvas.jpg");
            string base64EncodedImage = Convert.ToBase64String(bytes);

            Canvas captcha = new Canvas();
            captcha.SetBase64(base64EncodedImage);
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