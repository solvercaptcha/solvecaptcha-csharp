using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Tests
{
    [TestFixture]
    public class MTCaptchaTest : AbstractWrapperTestCase
    {
        [Test]
        public async Task TestAllOptions()
        {
            MTCaptcha mtCaptcha = new MTCaptcha();
            mtCaptcha.SetSiteKey("MTPublic-KzqLY1cKH");
            mtCaptcha.SetPageUrl("https://mysite.com/page/with/mtcaptcha");

            var parameters = new Dictionary<string, string>();
            parameters["method"] = "mt_captcha";
            parameters["sitekey"] = "MTPublic-KzqLY1cKH";
            parameters["pageurl"] = "https://mysite.com/page/with/mtcaptcha";
            parameters["soft_id"] = "4848";

            await CheckIfCorrectParamsSendAndResultReturned(mtCaptcha, parameters);
        }
    }
}