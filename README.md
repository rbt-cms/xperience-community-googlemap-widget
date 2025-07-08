# Xperience Community GoogleMap Widget

[![CI: Build and Test](https://github.com/rbt-cms/xperience-community-googlemap-widget/actions/workflows/ci.yml/badge.svg)](https://github.com/rbt-cms/xperience-community-googlemap-widget/actions/workflows/ci.yml) [![NuGet Package](https://img.shields.io/nuget/v/XperienceCommunity.GoogleMapWidget.svg)](https://www.nuget.org/packages/XperienceCommunity.GoogleMapWidget)

# Description
It displays map obtained from the Google maps service using Latitude,Longitude and Google API Key.

## Requirements

### Library Version Matrix

| Xperience Version | Library Version |
| ----------------- | --------------- |
| >= 29.6.0         | 1.0.0           |

### Dependencies


- [ASP.NET Core 8.0](https://dotnet.microsoft.com/en-us/download)
- [Xperience by Kentico](https://docs.kentico.com)


## Package Installation

Add the package to your application using the .NET CLI

```powershell
dotnet add package XperienceCommunity.GoogleMapWidget
```

## Quick Start

### Widget

This is a widget which allows you to add a GoogleMap Widget to your screen with certain attributes that can be configured while adding. The properties that can be configured are:

- IsVisible: Select this option to display the widget on the page
- Latitude*: Enter your desired Latitude
- Longitude*: Enter your desired Longitude

*Required fields

Make sure to add your Google Maps API token into ```appSettings.json: ```

```
GoogleMapsApiKey":"{key}",
```

### Screenshots

#1 -
![screenshot 1](https://github.com/rbt-cms/xperience-community-googlemap-widget/blob/main/images/1.png)

#2
![screenshot 2](https://github.com/rbt-cms/xperience-community-googlemap-widget/blob/main/images/2.png)

#3
![screenshot 3](https://github.com/rbt-cms/xperience-community-googlemap-widget/blob/main/images/3.png)

## Use DancingGoat sample

You can restore database with configured samples. View [DancingGoat Sample Database](https://github.com/rbt-cms/xperience-community-googlemap-widget/blob/main/db/xpDancingGoat_2960.bak).

Dashboard User Name: Administrator

Password: XbyK1234$

# License

This widget is provided under MIT license.

# Uninstall

Uninstall this from the NuGet Package Manager and rebuild the project.

# Reporting issues

Please report any issues seen, in the issue list. We will address at the earliest possibility.

# Compatibility

This widget has been tested on Xperience by Kentico version (29.6.0) and can be used on >=29.6.0 with .Net 8.0. 

