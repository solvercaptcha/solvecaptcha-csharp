using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class TextExample
    {
        public TextExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            Text captcha = new Text("If tomorrow is Saturday, what day is today?");

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