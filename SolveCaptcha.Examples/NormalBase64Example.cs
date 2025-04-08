using System;
using System.IO;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class NormalBase64Example
    {

        public NormalBase64Example(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            byte[] bytes = File.ReadAllBytes("resources/normal.jpg");
            string base64EncodedImage = Convert.ToBase64String(bytes);

            Normal captcha = new Normal();
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