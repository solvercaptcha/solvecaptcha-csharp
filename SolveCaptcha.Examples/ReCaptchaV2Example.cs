using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class ReCaptchaV2Example
    {
        public ReCaptchaV2Example(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            ReCaptcha captcha = new ReCaptcha();
            captcha.SetSiteKey("6LfD3PIbAAAAAJs_eEHvoOl75_83eXSqpPSRFJ_u");
            captcha.SetUrl("https://mysite.com/page/with/recaptcha-v2");

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