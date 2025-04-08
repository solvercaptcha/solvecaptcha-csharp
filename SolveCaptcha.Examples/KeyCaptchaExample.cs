using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class KeyCaptchaExample
    {
        public KeyCaptchaExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            KeyCaptcha captcha = new KeyCaptcha();
            captcha.SetUserId(184015);
            captcha.SetSessionId("9ff29e0176e78eb7ba59314f92dbac1b");
            captcha.SetWebServerSign("964635241a3e5e76980f2572e5f63452");
            captcha.SetWebServerSign2("3ca802a38ffc5831fa293ac2819b1204");
            captcha.SetUrl("https://mysite.com/page/with/keycaptcha");

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