This repository contains a basic .NET Blazor MAUI application integrated with Auth0 authentication.

Check out the article [Add Authentication to .Blazor Hybrid Apps in .NET MAUI](https://auth0.com/blog/add-authentication-to-blazor-hybrid-apps-in-dotnet-maui/) for the implementation details.

# Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine
- The required assets needed for your target(s) platform(s) as described [here](https://docs.microsoft.com/en-us/dotnet/maui/get-started/first-app)
- Visual Studio 2022 for Windows 17.3  or Visual Studio 2022 for Mac 17.4 (optional)

# To run this application

1. Clone the repo with the following command:

   ```bash
   git clone https://github.com/auth0-blog/dotnet-blazor-maui-auth0-app.git
   ```

2. Move to the `dotnet-blazor-maui-auth0-app` folder.

3. Open the `MauiProgram.cs` file and replace the `<YOUR_AUTH0_DOMAIN>` and `<YOUR_CLIENT_ID>` placeholders with your Auth0 domain and client id respectively (see [Register with Auth0](https://auth0.com/blog/add-authentication-to-blazor-hybrid-apps-in-dotnet-maui//#Register-with-Auth0) for more details).

4. Run the application with Visual Studio 2022 or use one of the following commands based on your target platform:

   ```bash
   # macOS target platform
   dotnet build -t:Run -f net8.0-maccatalyst
   
   # Android target platform
   dotnet build -t:Run -f net8.0-android
   
   # iOS target platform
   dotnet build -t:Run -f net8.0-ios
   
   # Windows target platform (⚠️ Currently not working! ⚠️)
   dotnet build -t:Run -f net8.0-windows10.0.19041.0 -p:WindowsPackageType=None
   ```
   
   > :warning: This application has been tested on macOS Sonoma 14.5 with Xcode 15.4.
   >
   > Be aware that several issues may prevent it from running on other platforms.
   >
   > For example, currently, OIDC integration in Windows is not yet possible (check [this issue](https://github.com/dotnet/maui/issues/2702) and the related [work in progress](https://github.com/microsoft/WindowsAppSDK/issues/441)), and there are [problems with iOS](https://github.com/dotnet/maui/issues/12124) and [macOS deployment](https://github.com/dotnet/maui/issues/12293).

