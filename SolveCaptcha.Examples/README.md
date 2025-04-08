# Examples

In the `SolveCaptcha.Examples` directory, you will find files with examples of solving supported captcha types.
For the successful execution of some examples, it is necessary to update the parameters of the captcha being sent.

To run an example, follow these steps:

1. Open and build the project `SolveCaptcha.Examples.csproj`
2. Navigate to the output directory.
3. Run the `SolveCaptcha.Examples.exe` file by passing two arguments. The first argument is the class name, which exactly matches the class name from the example. The second argument is the `apikey`. 

   Example command to run the `TencentExample.cs` file:

   ```cmd
   SolveCaptcha.Examples.exe TencentExample 12345678abcd9012345678abcd901234
   ```

You can find the full list of supported examples in the [Run.cs](./Run.cs) file.


