using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Tests
{
    [TestFixture]
    public class YandexTest : AbstractWrapperTestCase
    {
        [Test]
        public async Task TestAllOptions()
        {
            Yandex captcha = new Yandex();
            captcha.SetSiteKey("Y5Lh0tiycconMJGsFd3EbbuNKSp1yaZESUOIHfeV");
            captcha.SetUrl("https://rutube.ru");

            var parameters = new Dictionary<string, string>();
            parameters["method"] = "yandex";
            parameters["sitekey"] = "Y5Lh0tiycconMJGsFd3EbbuNKSp1yaZESUOIHfeV";
            parameters["pageurl"] = "https://rutube.ru";
            parameters["soft_id"] = "4848";

            await CheckIfCorrectParamsSendAndResultReturned(captcha, parameters);
        }
    }
}