﻿using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class CutcaptchaExample
    {
        public CutcaptchaExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            Cutcaptcha cutcaptcha = new Cutcaptcha();
            cutcaptcha.SetMiseryKey("a1488b66da00bf332a1488993a5443c79047e752");
            cutcaptcha.SetPageUrl("https://example.cc/foo/bar.html");
            cutcaptcha.SetApiKey("SAb83IIB");

            try
            {
                solver.Solve(cutcaptcha).Wait();
                Console.WriteLine("Captcha solved: " + cutcaptcha.Code);
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }
        }
    }
}