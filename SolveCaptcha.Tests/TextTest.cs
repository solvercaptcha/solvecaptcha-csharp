using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using SolveCaptcha.Captcha;

namespace SolveCaptcha.Tests
{
    [TestFixture]
    public class TextTest : AbstractWrapperTestCase
    {
        private string question = "Today is monday?";

        [Test]
        public async Task TestSimpleText()
        {
            Text captcha = new Text(question);

            var parameters = new Dictionary<string, string>();
            parameters["method"] = "post";
            parameters["textcaptcha"] = question;
            parameters["soft_id"] = "4848";

            await CheckIfCorrectParamsSendAndResultReturned(captcha, parameters);
        }

        [Test]
        public async Task TestTextParameter()
        {
            Text captcha = new Text();
            captcha.SetText(question);

            var parameters = new Dictionary<string, string>();
            parameters["method"] = "post";
            parameters["textcaptcha"] = question;
            parameters["soft_id"] = "4848";

            await CheckIfCorrectParamsSendAndResultReturned(captcha, parameters);
        }

        [Test]
        public async Task TestAllParameters()
        {
            Text captcha = new Text();
            captcha.SetText(question);
            captcha.SetLang("en");

            var parameters = new Dictionary<string, string>();
            parameters["method"] = "post";
            parameters["textcaptcha"] = question;
            parameters["lang"] = "en";
            parameters["soft_id"] = "4848";

            await CheckIfCorrectParamsSendAndResultReturned(captcha, parameters);
        }
    }
}