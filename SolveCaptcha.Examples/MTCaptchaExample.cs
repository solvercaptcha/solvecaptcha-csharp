using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class MTCaptchaExample
    {
        public MTCaptchaExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            MTCaptcha mtCaptcha = new MTCaptcha();
            mtCaptcha.SetSiteKey("MTPublic-KzqLY1cKH");
            mtCaptcha.SetPageUrl("https://mysite.com/page/with/mtcaptcha");

            try
            {
                solver.Solve(mtCaptcha).Wait();
                Console.WriteLine("Captcha solved: " + mtCaptcha.Code);
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }
        }
    }
}