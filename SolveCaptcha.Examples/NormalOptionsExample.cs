using System;
using System.IO;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class NormalOptionsExample
    {
        public NormalOptionsExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            Normal captcha = new Normal();
            captcha.SetFile("resources/normal_2.jpg");
            captcha.SetNumeric(4);
            captcha.SetMinLen(4);
            captcha.SetMaxLen(20);
            captcha.SetPhrase(true);
            captcha.SetCaseSensitive(true);
            captcha.SetCalc(false);
            captcha.SetLang("en");
            captcha.SetHintImg(new FileInfo("resources/normal_hint.jpg"));
            captcha.SetHintText("Type text");

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