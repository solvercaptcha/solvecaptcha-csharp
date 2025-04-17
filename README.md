![image](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/main_solvecaptcha.jpg)


[![python library](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/python_badge.png)](https://github.com/solvercaptcha/solvecaptcha-python)
[![javascript library](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/js_badge.png)](https://github.com/solvercaptcha/solvecaptcha-javascript)
[![go library](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/go_badge.png)](https://github.com/solvercaptcha/solvecaptcha-go)
[![ruby library](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/ruby_badge.png)](https://github.com/solvercaptcha/solvecaptcha-ruby)
[![cpp library](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/cpp_badge.png)](https://github.com/solvercaptcha/solvecaptcha-cpp)
[![php library](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/php_badge.png)](https://github.com/solvercaptcha/solvecaptcha-php)
[![java library](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/java_badge.png)](https://github.com/solvercaptcha/solvecaptcha-java)
[![csharp library](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/csharp_badge_active.png)](https://github.com/solvercaptcha/solvecaptcha-csharp)

# C# Captcha solver (.NET): Bypass reCAPTCHA, Cloudflare, hCaptcha, GeeTest and more

Use the [C# captcha solver](https://solvecaptcha.com/captcha-solver/csharp-captcha-solver-bypass) to automatically bypass any captcha — including reCAPTCHA v2, Invisible, v3, Enterprise, hCaptcha, Cloudflare Turnstile, GeeTest sliders, Amazon WAF, FunCaptcha, and both image and text-based challenges.

✅ Supported сaptcha solvers 

To get started quickly, check out the Captcha solver API documentation.

### Helpful links:
- [reCAPTCHA v2 solver](https://solvecaptcha.com/captcha-solver/recaptcha-v2-solver-bypass)
- [reCAPTCHA v3 solver](https://solvecaptcha.com/captcha-solver/recaptcha-v3-solver-bypass)
- [hCaptcha solver](https://solvecaptcha.com/captcha-solver/hcaptcha-solver-bypass)
- [Text and image captcha solver](https://solvecaptcha.com/captcha-solver/image-captcha-solver-bypass)
- [Cloudflare captcha solver (Turnstile)](https://solvecaptcha.com/captcha-solver/cloudflare-captcha-solver-bypass)
- [Amazon captcha solver (AWS WAF)](https://solvecaptcha.com/captcha-solver/amazon-captcha-solver-bypass)
- [GeeTest solver](https://solvecaptcha.com/captcha-solver/slider-captcha-solver-bypass)
- [FunCaptcha (Arkose Labs) solver](https://solvecaptcha.com/captcha-solver/funcaptcha-solver-bypass)
- Others

## 🛠️ Features 
- Fast and fully automated captcha bypass
- Native support for C# / .NET environments
- Works with **Selenium WebDriver**, **PuppeteerSharp**, or HTTP clients
- Clean and async-friendly code structure
- Pay only for successful solves
- 99.9% uptime
- 24/7 support for developers and integration teams

📦 Use Cases 
- Web scraping behind reCAPTCHA or Cloudflare
- Automating login and registration forms protected by captcha
- Integrating captcha solving in .NET testing pipelines
- Bot-detection bypass in QA and security research
- Custom automation flows in enterprise C# applications

Need help integrating with your C# project? [Open an issue](https://github.com/solvercaptcha/solvecaptcha-csharp/issues) or fork this repo to contribute.


- [C# Captcha solver (.NET): Bypass reCAPTCHA, Cloudflare, hCaptcha, GeeTest and more](#c-captcha-solver-net-bypass-recaptcha-cloudflare-hcaptcha-geetest-and-more)
  - [Installation](#installation)
  - [Configuration](#configuration)
    - [SolveCaptcha instance options](#solvecaptcha-instance-options)
  - [Solve captcha](#solve-captcha)
    - [Captcha options](#captcha-options)
    - [Basic example](#basic-example)
    - [Normal Captcha](#normal-captcha)
    - [Text Captcha](#text-captcha)
    - [reCAPTCHA v2](#recaptcha-v2)
    - [reCAPTCHA v3](#recaptcha-v3)
    - [FunCaptcha](#funcaptcha)
    - [GeeTest](#geetest)
    - [GeeTest v4](#geetest-v4)
    - [hCaptcha](#hcaptcha)
    - [KeyCaptcha](#keycaptcha)
    - [Capy](#capy)
    - [Grid](#grid)
    - [Canvas](#canvas)
    - [ClickCaptcha](#clickcaptcha)
    - [Rotate](#rotate)
    - [Audio Captcha](#audio-captcha)
    - [Yandex](#yandex)
    - [Lemin Cropped Captcha](#lemin-cropped-captcha)
    - [Cloudflare Turnstile](#cloudflare-turnstile)
    - [Amazon WAF](#amazon-waf)
    - [Friendly Captcha](#friendly-captcha)
    - [MTCaptcha](#mtcaptcha)
    - [Cutcaptcha](#cutcaptcha)
    - [CyberSiARA](#cybersiara)
    - [DataDome](#datadome)
    - [atbCAPTCHA](#atbcaptcha)
    - [Tencent](#tencent)
  - [Other methods](#other-methods)
    - [send / getResult](#send--getresult)
    - [balance](#balance)
    - [report](#report)
  - [Proxies](#proxies)
  - [Error handling](#error-handling)
  - [Get in touch](#get-in-touch)
- [License](#license)

## Installation

(Coming soon) Install nuget package from [nuget]:

`dotnet add package solvecaptcha-csharp`

### Installation from GitHub

You can also install the library directly from GitHub.

Clone the repository:

```bash
git clone https://github.com/solvercaptcha/solvecaptcha-csharp.git
```

Add the project as a dependency:

```xml
<ItemGroup>
  <ProjectReference Include="path/to/solvecaptcha-csharp/SolveCaptcha/SolveCaptcha.csproj" />
</ItemGroup>
```

## Configuration

`SolveCaptcha` instance can be created like this:

```csharp
SolveCaptcha solver = new SolveCaptcha('YOUR_API_KEY');
```

Also there are few options that can be configured:

```csharp
solver.DefaultTimeout = 120;
solver.RecaptchaTimeout = 600;
solver.PollingInterval = 10;
```

### SolveCaptcha instance options

| Option           | Default value | Description                                                                                                                                        |
| ---------------- | ------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- |
| defaultTimeout   | 120           | Polling timeout in seconds for all captcha types except reCAPTCHA. Defines how long the module tries to get the answer from `res.php` API endpoint |
| recaptchaTimeout | 600           | Polling timeout for reCAPTCHA in seconds. Defines how long the module tries to get the answer from `res.php` API endpoint                          |
| pollingInterval  | 10            | Interval in seconds between requests to `res.php` API endpoint, setting values less than 5 seconds is not recommended                              |

> To get the answer manually use [getResult method](#send--getresult)

## Solve captcha

When you submit any image-based captcha use can provide additional options to help solvecaptcha workers to solve it properly.

### Captcha options

| Option        | Default Value | Description                                                                                        |
| ------------- | ------------- | -------------------------------------------------------------------------------------------------- |
| numeric       | 0             | Defines if captcha contains numeric or other symbols [see more info in the API docs][post options] |
| minLength     | 0             | minimal answer length                                                                              |
| maxLength     | 0             | maximum answer length                                                                              |
| phrase        | 0             | defines if the answer contains multiple words or not                                               |
| caseSensitive | 0             | defines if the answer is case sensitive                                                            |
| calc          | 0             | defines captcha requires calculation                                                               |
| lang          | -             | defines the captcha language, see the [list of supported languages]                                |
| hintImg       | -             | an image with hint shown to workers with the captcha                                               |
| hintText      | -             | hint or task text shown to workers with the captcha                                                |

Below you can find basic examples for every captcha type. Check out [examples directory] to find more examples with all available options.

### Basic example

Example below shows a basic solver call example with error handling.

```csharp
Normal captcha = new Normal();
captcha.SetFile("path/to/captcha.jpg");
captcha.SetMinLen(4);
captcha.SetMaxLen(20);
captcha.SetCaseSensitive(true);
captcha.SetLang("en");

try
{
    await solver.Solve(captcha);
    Console.WriteLine("Captcha solved: " + captcha.Code);
}
catch (Exception e)
{
    Console.WriteLine("Error occurred: " + e.Message);
}
```

### Normal Captcha

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_normal_captcha)</sup>

To bypass a normal captcha (distorted text on image) use the following method. This method also can be used to recognize any text on the image.

```csharp
Normal captcha = new Normal();
captcha.SetFile("path/to/captcha.jpg");
captcha.SetNumeric(4);
captcha.SetMinLen(4);
captcha.SetMaxLen(20);
captcha.SetPhrase(true);
captcha.SetCaseSensitive(true);
captcha.SetCalc(false);
captcha.SetLang("en");
captcha.SetHintImg(new FileInfo("path/to/hint.jpg"));
captcha.SetHintText("Type red symbols only");
```

### Text Captcha

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_text_captcha)</sup>

This method can be used to bypass a captcha that requires to answer a question provided in clear text.

```csharp
Text captcha = new Text();
captcha.SetText("If tomorrow is Saturday, what day is today?");
captcha.SetLang("en");
```

### reCAPTCHA v2

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_recaptchav2_new)</sup>

Use this method to solve reCAPTCHA V2 and obtain a token to bypass the protection.

```csharp
ReCaptcha captcha = new ReCaptcha();
captcha.SetSiteKey("6Le-wvkSVVABCPBMRTvw0Q4Muexq1bi0DJwx_mJ-");
captcha.SetUrl("https://mysite.com/page/with/recaptcha");
captcha.SetInvisible(true);
captcha.SetEnterprise(false);
captcha.SetAction("verify");
captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");
```

### reCAPTCHA v3

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_recaptchav3)</sup>

This method provides reCAPTCHA V3 solver and returns a token.

```csharp
ReCaptcha captcha = new ReCaptcha();
captcha.SetSiteKey("6Le-wvkSVVABCPBMRTvw0Q4Muexq1bi0DJwx_mJ-");
captcha.SetUrl("https://mysite.com/page/with/recaptcha");
captcha.SetVersion("v3");
captcha.SetEnterprise(false);
captcha.SetDomain("google.com");
captcha.SetAction("verify");
captcha.SetScore(0.3);
captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");
```

### FunCaptcha

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_funcaptcha_new)</sup>

FunCaptcha (Arkoselabs) solving method. Returns a token.

```csharp
FunCaptcha captcha = new FunCaptcha();
captcha.SetSiteKey("69A21A01-CC7B-B9C6-0F9A-E7FA06677FFC");
captcha.SetUrl("https://mysite.com/page/with/funcaptcha");
captcha.SetSUrl("https://client-api.arkoselabs.com");
captcha.SetUserAgent("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.61 Safari/537.36");
captcha.SetData("anyKey", "anyValue");
captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");
```

### GeeTest

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_geetest)</sup>

Method to solve GeeTest puzzle captcha. Returns a set of tokens as JSON.

```csharp
GeeTest captcha = new GeeTest();
captcha.SetGt("f2ae6cadcf7886856696502e1d55e00c");
captcha.SetApiServer("api-na.geetest.com");
captcha.SetChallenge("12345678abc90123d45678ef90123a456b");
captcha.SetUrl("https://mysite.com/captcha.html");
captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");
```

### GeeTest v4

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_geetest_v4)</sup>

Method to solve GeeTest v4 puzzle captcha. Returns a set of tokens as JSON.

```csharp
GeeTestV4 captcha = new GeeTestV4();
captcha.SetCaptchaId("72bf15796d0b69c43867452fea615052");
captcha.SetChallenge("12345678abc90123d45678ef90123a456b");
captcha.SetUrl("https://mysite.com/captcha.html");
```

### hCaptcha

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_hcaptcha)</sup>

Use this method to solve hCaptcha challenge. Returns a token to bypass captcha.

```csharp
HCaptcha captcha = new HCaptcha();
captcha.SetSiteKey("10000000-ffff-ffff-ffff-000000000001");
captcha.SetUrl("https://www.site.com/page/");
captcha.SetData("foo");
captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");
```

### KeyCaptcha

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_keycaptcha)</sup>

Token-based method to solve KeyCaptcha.

```csharp
KeyCaptcha captcha = new KeyCaptcha();
captcha.SetUserId(10);
captcha.SetSessionId("493e52c37c10c2bcdf4a00cbc9ccd1e8");
captcha.SetWebServerSign("9006dc725760858e4c0715b835472f22");
captcha.SetWebServerSign2("2ca3abe86d90c6142d5571db98af6714");
captcha.SetUrl("https://www.keycaptcha.ru/demo-magnetic/");
captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");
```

### Capy

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_capy)</sup> -->

Token-based method to bypass Capy puzzle captcha.

```csharp
Capy captcha = new Capy();
captcha.SetSiteKey("PUZZLE_Abc1dEFghIJKLM2no34P56q7rStu8v");
captcha.SetUrl("https://www.mysite.com/captcha/");
captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");
```

### Grid

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_grid)</sup>

Grid method is originally called Old reCAPTCHA V2 method. The method can be used to bypass any type of captcha where you can apply a grid on image and need to click specific grid boxes. Returns numbers of boxes.

```csharp
Grid captcha = new Grid();
captcha.SetFile("path/to/captcha.jpg");
captcha.SetRows(3);
captcha.SetCols(3);
captcha.SetPreviousId(0);
captcha.SetCanSkip(false);
captcha.SetLang("en");
captcha.SetHintImg(new FileInfo("path/to/hint.jpg"));
captcha.SetHintText("Select all images with an Orange");
```

### Canvas

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#canvas)</sup>

Canvas method can be used when you need to draw a line around an object on image. Returns a set of points' coordinates to draw a polygon.

```csharp
Canvas captcha = new Canvas();
captcha.SetFile("path/to/captcha.jpg");
captcha.SetPreviousId(0);
captcha.SetCanSkip(false);
captcha.SetLang("en");
captcha.SetHintImg(new FileInfo("path/to/hint.jpg"));
captcha.SetHintText("Draw around apple");
```

### ClickCaptcha

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_clickcaptcha)</sup>

ClickCaptcha (Coordinates) method returns coordinates of points on captcha image. Can be used if you need to click on particular points on the image.

```csharp
Coordinates captcha = new Coordinates();
captcha.SetFile("path/to/captcha.jpg");
captcha.SetLang("en");
captcha.SetHintImg(new FileInfo("path/to/hint.jpg"));
captcha.SetHintText("Select all images with an Orange");
```

### Rotate

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_rotatecaptcha)</sup>

This method can be used to solve a captcha that asks to rotate an object. Mostly used to bypass FunCaptcha. Returns the rotation angle.

```csharp
Rotate captcha = new Rotate();
captcha.SetFile("path/to/captcha.jpg");
captcha.SetAngle(40);
captcha.SetLang("en");
captcha.SetHintImg(new FileInfo("path/to/hint.jpg"));
captcha.SetHintText("Put the images in the correct way up");
```

### Audio Captcha

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#audio)</sup> -->

This method can be used to solve a audio captcha (mp3 formats only).
You must provide the language as `lang = 'en'`. Supported languages are "en", "ru", "de", "el", "pt", "fr".

```csharp
AudioCaptcha captcha = new AudioCaptcha();
byte[] bytes = File.ReadAllBytes("../../resources/audio-en.mp3");
string base64EncodedImage = Convert.ToBase64String(bytes);
captcha.SetBase64(base64EncodedImage);
```

### Yandex

Use this method to solve Yandex and obtain a token to bypass the protection.

```csharp
Yandex captcha = new Yandex();
captcha.SetSiteKey("Y5Lh0tiycconMJGsFd3EbbuNKSp1yaZESUOIHfeV");
captcha.SetUrl("https://rutube.ru");
```

### Lemin Cropped Captcha

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#lemin)</sup> -->

Use this method to solve Lemin and obtain a token to bypass the protection.

```csharp
Lemin captcha = new Lemin();
captcha.SetCaptchaId("CROPPED_d3d4d56_73ca4008925b4f83a8bed59c2dd0df6d");
captcha.SetApiServer("api.leminnow.com");
captcha.SetUrl("http://sat2.aksigorta.com.tr");
```

### Cloudflare Turnstile

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#solving_cloudflare_turnstile)</sup>

Use this method to solve Cloudflare Turnstile and obtain a token to bypass the protection.

```csharp
Turnstile captcha = new Turnstile();
captcha.SetSiteKey("0x4AAAAAAAChNiVJM_WtShFf");
captcha.SetUrl("https://ace.fusionist.io");
captcha.SetData("foo");
captcha.SetPageData("bar");
captcha.SetAction("baz");
```

### Amazon WAF

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#amazon-waf)</sup> -->

Use this method to solve Amazon WAF Captcha also known as AWS WAF Captcha is a part of Intelligent threat mitigation for Amazon AWS. Returns JSON with the token.

```csharp
AmazonWaf captcha = new AmazonWaf();
captcha.SetSiteKey("AQIDAHjcYu/GjX+QlghicBgQ/7bFaQZ+m5FKCMDnO+vTbNg96AF5H1K/siwSLK7RfstKtN5bAAAAfjB8BgkqhkiG9w0BBwagbzBtAgEAMGgGCSqGSIb3DQEHATAeBglg");
captcha.SetUrl("https://non-existent-example.execute-api.us-east-1.amazonaws.com");
captcha.SetContext("test_iv");
captcha.SetIV("test_context");
```

### Friendly Captcha

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#friendly-captcha)</sup> -->

Use this method to solve Friendly Captcha. Returns a token to bypass the captcha.

> [!IMPORTANT]
> To successfully use the received token, the captcha widget must not be loaded on the page. To do this, you need to abort request to `/friendlycaptcha/...module.min.js` on the page. When the captcha widget is already loaded on the page, there is a high probability that the received token will not work.

```csharp
FriendlyCaptcha captcha = new FriendlyCaptcha();
captcha.SetSiteKey("2FZFEVS1FZCGQ9");
captcha.SetUrl("https://example.com");
```

### MTCaptcha

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#mtcaptcha)</sup> -->

Use this method to solve MTCaptcha. Returns a token to bypass the captcha.

```csharp
MTCaptcha captcha = new MTCaptcha();
captcha.SetSiteKey("MTPublic-KzqLY1cKH");
captcha.SetPageUrl("https://mysite.com/page/with/mtcaptcha");
```

### Cutcaptcha

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#cutcaptcha)</sup> -->

Use this method to solve Cutcaptcha. Returns a token to bypass the captcha.

```csharp
Cutcaptcha captcha = new Cutcaptcha();
captcha.SetMiseryKey("a1488b66da00bf332a1488993a5443c79047e752");
captcha.SetPageUrl("https://example.cc/foo/bar.html");
captcha.SetApiKey("SAb83IIB");
```

### CyberSiARA

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#cybersiara)</sup> -->

Use this method to solve CyberSiARA. Returns a token to bypass the captcha.

```csharp
CyberSiARA cyberSiARA = new CyberSiARA();
cyberSiARA.SetMasterUrlId("tpjOCKjjpdzv3d8Ub2E9COEWKt1vl1Mv");
cyberSiARA.SetPageUrl("https://demo.mycybersiara.com/");
cyberSiARA.SetUserAgent("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36");
```

### DataDome

<!-- <sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#datadome)</sup> -->

Use this method to solve DataDome captcha.

> [!IMPORTANT]
> To solve the DataDome captcha, you must use a proxy. It is recommended to use [residential proxies].

```csharp
DataDome dataDome = new DataDome();
dataDome.SetCapthaUrl("https://geo.captcha-delivery.com/captcha/?initialCid=AHrlqAAA...P~XFrBVptk&t=fe&referer=https%3A%2F%2Fhexample.com&s=45239&e=c538be..c510a00ea");
dataDome.SetPageUrl("https://example.com/");
dataDome.SetProxy("http", "username:password@1.2.3.4:5678");
dataDome.SetUserAgent("Mozilla/5.0 (Linux; Android 10; K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Mobile Safari/537.3");
```

### atbCAPTCHA
<!-- 
<sup>[API method description.](hhttps://solvecaptcha.com/captcha-solver-api#atb-captcha)</sup> -->

Use this method to solve atbCAPTCHA. Returns a token to bypass the captcha.

```csharp
AtbCAPTCHA atbCAPTCHA = new AtbCAPTCHA();
atbCAPTCHA.SetAppId("af23e041b22d000a11e22a230fa8991c");
atbCAPTCHA.SetApiServer("https://cap.aisecurius.com");
atbCAPTCHA.SetPageUrl("https://www.example.com/");
```

### Tencent
<!-- 
<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#tencent)</sup> -->

Use this method to solve Tencent captcha. Returns a token to bypass the captcha.

```csharp
Tencent tencent = new Tencent();
tencent.SetAppId("190014885");
tencent.SetPageUrl("https://www.example.com/");
```

## Other methods

### send / getResult

These methods can be used for manual captcha submission and answer polling.

```csharp
string captchaId = await solver.Send(captcha);

Task.sleep(20 * 1000);

string code = await solver.GetResult(captchaId);
```

### balance

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#additional)</sup>

Use this method to get your account's balance

```csharp
double balance = await solver.Balance();
```

### report

<sup>[API method description.](https://solvecaptcha.com/captcha-solver-api#complain)</sup>

Use this method to report good or bad captcha answer.

```csharp
await solver.Report(captcha.Id, true); // captcha solved correctly
await solver.Report(captcha.Id, false); // captcha solved incorrectly
```

## Proxies

You can pass your proxy as an additional argument for methods: recaptcha, funcaptcha, geetest, geetest v4, hcaptcha, keycaptcha, capy puzzle, lemin, cloudflare turnstile, amazon waf, friendly captcha, mtcaptcha, cutcaptcha, cybersiara, datadome, atbcaptcha, tencent and etc. The proxy will be forwarded to the API to solve the captcha.

```csharp
captcha.SetProxy("HTTPS", "login:password@IP_address:PORT");
```

## Error handling

If case of an error captcha solver throws an exception. It's important to properly handle these cases. We recommend to use `try catch` to handle exceptions.
The list of all errors can be found in the [API documentation](https://solvecaptcha.com/captcha-solver-api#error_handling).

```csharp
try
{
    await solver.Solve(captcha);
}
catch (ValidationException e)
{
    // invalid parameters passed
}
catch (NetworkException e)
{
    // network error occurred
}
catch (ApiException e)
{
    // api respond with error
}
catch (TimeoutException e)
{
    // captcha is not solved so far
}
```

## Get in touch

[![Send email to support](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/email_button.png)](mailto:info@solvecaptcha.com)
[![Create ticket](https://raw.githubusercontent.com/solvercaptcha/solvecaptcha-csharp/main/assets/ticket_button.png)](https://solvecaptcha.com/support/faq#create-ticket)

# License

The code in this repository is licensed under the MIT License. See the [LICENSE](./LICENSE) file for more details.

<!-- Shared links -->
[nuget]: https://www.nuget.org/packages/solvecaptcha-csharp/
[solvecaptcha]: https://solvecaptcha.com/
[Post options]: https://solvecaptcha.com/captcha-solver-api#normal_post
[list of supported languages]: https://solvecaptcha.com/solvecaptcha-api#language
[Examples directory]: /SolveCaptcha.Examples
