﻿using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class AtbCAPTCHAExample
    {
        public AtbCAPTCHAExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            AtbCAPTCHA atbCAPTCHA = new AtbCAPTCHA();
            atbCAPTCHA.SetAppId("af23e041b22d000a11e22a230fa8991c");
            atbCAPTCHA.SetApiServer("https://cap.aisecurius.com");
            atbCAPTCHA.SetPageUrl("https://www.example.com/");

            try
            {
                solver.Solve(atbCAPTCHA).Wait();
                Console.WriteLine("Captcha solved: " + atbCAPTCHA.Code);
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }
        }
    }
}