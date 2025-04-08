using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class ReCaptchaV3Example
    {
        public ReCaptchaV3Example(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            ReCaptcha captcha = new ReCaptcha();
            captcha.SetSiteKey("6LfB5_IbAAAAAMCtsjEHEHKqcB9iQocwwxTiihJu");
            captcha.SetUrl("https://mysite.com/page/with/recaptcha-v3");
            captcha.SetVersion("v3");

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