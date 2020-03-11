# Tamagotchi

#### C# Basic Web Application Project for Epicodus, 03/11/2020

#### By Andrew Philott, Krista Rutz and Andriy Veremyeyev

## Description

Web app where you can create a Tamagotchi object by giving it a name and submitting a form. Main page displaying the names of all your Tamagotchi objects with the values of their properties. It has buttons to feed it, play with it, and put it to sleep.

## Specs:

| Spec                                                                                                | Input           | Output             |
| :-------------------------------------------------------------------------------------------------- | :-------------- | :----------------- |
| Create a Tamagotchi object with a name and properties: food, attention, and rest                    | Yoyo            |                    |
| Create a list of Tamagotchi objects with mentioned above properties and main page shows all of them | Yoyo            |                    |
| Create a button to increase Food Level for every Tamagotchi                                         | Yoyo            |                    |
| Create button to pass a time and decrease properties of all tamagotchis                             | Decrease Levels | Food-=10,          |
| Once some of tamagotchi's property level reached 0 it shows that tamagotchi is dead                 | Food = 0        | Tamagotchi is dead |

- main page shows all tamagotchis and all of their property values as a GET
- buttons --> call methods as a PATCH
  - feed(), playWith(), putToSleep()
- button to pass time --> decrease all properties.
- when any tamagotchi has any property "0", report dead...(DELETE?)

## Setup/Installation Requirements

- Download .NET application [for Mac](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) or [for Windows](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer) and install it
- Download or clone this repository to your computer
- Open terminal
- Run "dotnet run" to run the application

## Known Bugs

No known bugs

## Support and contact details

For feedback, questions and/or ideas, please email

## Technologies Used

- HTML
- CSS
- .NET
- C#
- ASP.NET Core MVC

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **Andrew Philott, Krista Rutz and Andriy Veremyeyev**
