using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Tests
{
    [TestFixture]
    public class HCaptchaTest : AbstractWrapperTestCase
    {
        [Test]
        public async Task TestAllOptions()
        {
            HCaptcha captcha = new HCaptcha();
            captcha.SetSiteKey("f1ab2cdefa3456789012345b6c78d90e");
            captcha.SetUrl("https://www.site.com/page/");
            captcha.SetData("foo");

            var parameters = new Dictionary<string, string>();
            parameters["method"] = "hcaptcha";
            parameters["sitekey"] = "f1ab2cdefa3456789012345b6c78d90e";
            parameters["pageurl"] = "https://www.site.com/page/";
            parameters["data"] = "foo";
            parameters["soft_id"] = "4848";

            await CheckIfCorrectParamsSendAndResultReturned(captcha, parameters);
        }
    }
}