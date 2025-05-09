using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Tests
{
    [TestFixture]
    public class AudioTest : AbstractWrapperTestCase
    {

        [Test]
        public async Task TestAllParameters()
        {
            byte[] bytes = File.ReadAllBytes("../../../resources/audio-en.mp3");
            string base64EncodedImage = Convert.ToBase64String(bytes);


            AudioCaptcha captcha = new AudioCaptcha();
            captcha.SetBase64(base64EncodedImage);
            captcha.SetLang("en");


            var parameters = new Dictionary<string, string>();
            parameters["method"] = "audio";
            parameters["lang"] = "en";
            parameters["body"] = base64EncodedImage;
            parameters["soft_id"] = "4848";


            await CheckIfCorrectParamsSendAndResultReturned(captcha, parameters);
        }

    }
}