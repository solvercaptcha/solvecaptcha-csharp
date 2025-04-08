using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class FriendlyCaptchaExample
    {
        public FriendlyCaptchaExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            FriendlyCaptcha captcha = new FriendlyCaptcha();
            captcha.SetSiteKey("2FZFEVS1FZCGQ9");
            captcha.SetUrl("https://example.com");

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