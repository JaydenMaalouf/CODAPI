[![NuGet](https://img.shields.io/badge/nuget-1.0.0-brightgreen.svg)](https://www.nuget.org/packages/CODAPI/)

# CODAPI - C# Call Of Duty API
An unofficial .NET API Wrapper for the Call Of Duty API (http://bo4tracker.com)
Documentation is found below!

## Installation
Our stable build is available from NuGet through the CODAPI metapackage:
- [CODAPI](https://www.nuget.org/packages/CODAPI/)

## Getting Started
Once you have added the NuGet Package to your Project, you will need to add the `using CallOfDutyAPI;` to your class header.
Then simply instance the CODAPI class with your API key, like so:
```csharp
var API = new CODAPI();
```
Now you can easily make calls to the API.

## GetUser()
The base user class `CODUser` contains the UID and Username of a user. 
If you already know a user's UID or Username, you can use the `GetUser()` method to return an `CODUser` object.
- Username:
```csharp
var user = API.GetUser("username");
```
- UID:
```csharp
var user = API.GetUser(new UID("uid"));
```

If you're wanting to get a user's BR stats, you can simply use `.Stats.GetStatsAsync();` and it will return the requested stats.
```csharp
var user = API.GetUser("username");
var stats = await user.Stats.GetStatsAsync();
```