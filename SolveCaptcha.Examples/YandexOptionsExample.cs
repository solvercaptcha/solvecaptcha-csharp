using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class YandexOptionsExample
    {
        public YandexOptionsExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            Yandex captcha = new Yandex();
            captcha.SetSiteKey("Y5Lh0tiycconMJGsFd3EbbuNKSp1yaZESUOIHfeV");
            captcha.SetUrl("https://rutube.ru");
            captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");

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