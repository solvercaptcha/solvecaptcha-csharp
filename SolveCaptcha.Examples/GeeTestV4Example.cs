using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class GeeTestV4Example
    {
        public GeeTestV4Example(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            GeeTestV4 captcha = new GeeTestV4();
            captcha.SetCaptchaId("72bf15796d0b69c43867452fea615052");
            captcha.SetChallenge("12345678abc90123d45678ef90123a456b");
            captcha.SetUrl("https://mysite.com/page/with/geetest-v4");

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