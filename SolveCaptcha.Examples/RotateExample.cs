using System;
using System.IO;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class RotateExample
    {
        public RotateExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            byte[] bytes = File.ReadAllBytes("resources/rotate.jpg");
            string base64EncodedImage = Convert.ToBase64String(bytes);
            Console.WriteLine("base64EncodedImage: " + base64EncodedImage);


            Rotate captcha = new Rotate();
            captcha.SetBase64(base64EncodedImage);

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