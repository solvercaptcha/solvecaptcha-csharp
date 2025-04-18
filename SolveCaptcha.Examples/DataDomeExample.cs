﻿using System;
using System.Linq;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Examples
{
    public class DataDomeExample
    {
        public DataDomeExample(string apiKey)
        {
            SolveCaptcha solver = new SolveCaptcha(apiKey);

            DataDome dataDome = new DataDome();
            dataDome.SetCapthaUrl("https://geo.captcha-delivery.com/captcha/?initialCid=AHrlqAAA...P~XFrBVptk&t=fe&referer=https%3A%2F%2Fhexample.com&s=45239&e=c538be..c510a00ea");
            dataDome.SetPageUrl("https://example.com/");
            dataDome.SetProxy("http", "username:password@1.2.3.4:5678");
            dataDome.SetUserAgent("Mozilla/5.0 (Linux; Android 10; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Mobile Safari/537.3");

            try
            {
                solver.Solve(dataDome).Wait();
                Console.WriteLine("Captcha solved: " + dataDome.Code);
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }
        }
    }
}