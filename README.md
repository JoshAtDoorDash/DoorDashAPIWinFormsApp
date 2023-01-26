# DoorDash API Windows Forms Sample App

This application targets [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) and requires a Windows OS to run. The code source and build files provided in this repository are samples and not intended for production and are not supported. 

## Running Sample
Follow these steps to run the sample app:
1. Install the [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) runtime or SDK.
2. Unzip the DoorDashAPIWinFormsApp.zip file in a local folder on a Windows machine. 
3. Double click DoorDashAPIWinFormsApp.exe from the uncompressed folder. 
4. Provide the DoorDash Credentails (Developer ID, Key ID, and Signing Secret) created in the [DoorDash Developer Portal](https://developer.doordash.com/portal/integration/drive/credentials).
5. Click the "Update JWT" button.

## To Build Sample App with the .NET CLI
Follow these steps to build the sample app:
1. Install the [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) SDK (includes the .NET CLI).
2. Clone this repo to local folder or download and the files in the source folder into a local directory. 
3. Open a command window and change the directory to folder that folder that contains the source files
4. Run the following command: ``dotnet build``
5. The applicaiton can be run from within the **../bin/Debug/net7.0-windows/** folder.

## To Build Sample App with Visual Studio
Follow these steps to build the sample app:
1. Install the [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) SDK (includes the .NET CLI).
2. Install Visual Studio 2022 (Community, Professional, or Enterprise).
3. Clone this repo to local folder or download and the files in the source folder into a local directory. 
4. Open the **DoorDashAPIWinFormsApp.csproj** project in Visual Studio.

## More About DoorDash Credentails
- [DoorDash JWT Format](https://developer.doordash.com/en-US/docs/drive/reference/JWTs/)
- [Manage DoorDash Credentails](https://developer.doordash.com/en-US/docs/drive/how_to/manage_credentials/)
- [Create DoorDash JSON Web Tokens (JWTs)](https://developer.doordash.com/en-US/docs/drive/how_to/JWTs)

## Related Utilities</h2>
- [auth0 JWT Debugger](https://jwt.io/)
- [DoorDash API JWT JSFiddle Sample](https://jsfiddle.net/joshAtDoorDash/yha049fn/)
- [make-doordash-jwt CLI](https://github.com/infin8x/make-doordash-jwt)
- [DoorDash API get started with Postman](https://developer.doordash.com/en-US/docs/drive/tutorials/get_started_postman/)
