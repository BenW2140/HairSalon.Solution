# _Eau Claire's Salon_

#### _Manage hair salon, July 31, 2020_

#### By _**Ben White**_

## Description

_This application allows a user to add and view stylists for their hair salon, as well as, add and view clients for those stylists_

## Setup/Installation Requirements

Recreating the database:

1. In the Administration window, select Data Import/Restore.

2. In Import Options select Import from Self-Contained File.

3. Navigate to the file that was created.

4. Under Default Schema to be Imported To, select the New button.

5. Enter a name for the database
  * Click Ok.
  * Click Start Import.

6. Reopen the Schemas tab. Right click and select Refresh All and the database will appear

Software Requirements:

1. This program utilizes .NET version 2.2, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK version 2.2 or
      greater patch version, but do not upgrade to a higher minor version number.

2. Clone this repository onto your computer: https://github.com/...

3. In your preferred terminal window, navigate into PROJECTNAME.SOLUTIONS/PROJECTNAME using cd (i.e. cd
   desktop/PROJECTNAME.SOLUTIONS/PROJECTNAME) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore

5. To initiate this terminal program, run the command: $ dotnet run

6. To run the test suite included with this project, within the terminal navigate into PROJECTNAME.TESTS and run the following commands:
  * $ dotnet restore
  * $ dotnet test

## User Stories
* As the salon owner, I need to be able to see a list of all stylists.
* As the salon owner, I need to be able to select a stylist, see their details, and see a list of all
  clients that belong to that stylist.
* As the salon owner, I need to add new stylists to our system when they are hired.
* As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to
  add a client if no stylists have been added.

## Known Bugs

_Possibly got the One-Many relationship backwards_

## Support and contact details

_Ben White: bwhite2140@outlook.com_

## Technologies Used

_Git, C#, .NET, Entity, SQL_

### License

*MIT License*

Copyright (c) 2020 **_Ben White_**