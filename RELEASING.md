# solvecaptcha-csharp package releasing

## Release Using GitHub actions (Recommended)

```
git tag v1.0.0
git push origin v1.0.0
```

## Manualy

### Step 1. Build the package with the updated version

1. Open a terminal or command prompt and navigate to the directory where your project is located (the `SolveCaptcha.csproj` file).

2. Run the command to build the package in Release mode. For example:


    `dotnet pack --configuration Release`


3. After successful execution of the command, the package will be created in the bin/Release/ folder. Check that the file name includes the new version, for example:


    `solvecaptcha-csharp.1.0.0.nupkg`


## Step 2. Checking the created file

Make sure that:
- The file is located in the `bin/Release/` folder.
- The file name corresponds to the format `<PackageID>.<Version>`.nupkg (in your case it should be `solvecaptcha-csharp.1.0.0.nupkg`).
- All updated metadata (including the version) is correctly reflected in the file.

## Step 3. Publishing on NuGet.org
The next step is to publish the package. To publish, use the command:
    `dotnet nuget push bin/Release/solvecaptcha-csharp.1.0.0.nupkg --api-key YOUR_API_KEY --source https://api.nuget.org/v3/index.json`

    - `YOUR_API_KEY` - is your API key created on NuGet.org.
    - The path to the file must be correct and point to the one you just created.the nupkg file.