using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class TencentExample
    {
        public TencentExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            Tencent tencent = new Tencent();
            tencent.SetAppId("190014885");
            tencent.SetPageUrl("https://www.example.com/");

            try
            {
                solver.Solve(tencent).Wait();
                Console.WriteLine("Captcha solved: " + tencent.Code);
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }
        }
    }
}