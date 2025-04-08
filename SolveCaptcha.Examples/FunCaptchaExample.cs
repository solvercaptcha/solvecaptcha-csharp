using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class FunCaptchaExample
    
    {
        public FunCaptchaExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            FunCaptcha captcha = new FunCaptcha();
            captcha.SetSiteKey("69A21A01-CC7B-B9C6-0F9A-E7FA06677FFC");
            captcha.SetUrl("https://mysite.com/page/with/funcaptcha");

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