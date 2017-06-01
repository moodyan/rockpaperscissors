# _Rock Paper Scissors_

#### _App created for Epicodus lesson, May 2017_

#### By _**Alyssa Moody**_

## Description

_A simple app where two players can enter "rock", "paper", or "scissors" and see who wins._

## Program Specifications

| Description  | Input Example | Output Example |
| ------------- | ------------- | ------------- |
| The program allows two users to input "rock", "paper", or "scissors". All other entries return an error.  | Hello   | "Error, please enter valid gameplay word."  |
| The program recognizes both lowercase and uppercase inputs.  | ROCK   | "rock"  |
| The program compares the two inputs and determines a winner.  | rock vs paper   | "PAPER wins!"  |

## Setup/Installation Requirements

_Runs on the .Net Framework._


_Install Visual Studio 2015. https://go.microsoft.com/fwlink/?LinkId=532606 ._

_Install ASP.Net 5. This will give you access to the .NET Framework. https://go.microsoft.com/fwlink/?LinkId=627627 ._

_Restart PowerShell. While located in your machine's Home directory, enter the command > dnvm upgrade._

_Requires Nancy Web Framework located at: http://nancyfx.org/. You can also do this via Windows PowerShell with the command > **Install-Package Nancy**_

#### _GitHub_
* _Download or clone project repository onto desktop from GitHub_


 _In PowerShell, cd into the project folder. Enter the command > **dnu restore**_

 _Enter the command > **dnx kestrel**_


 _In your prefered browser, navigate to http://localhost:5004/ and you should see the application._

## Known Bugs

_When two users enter the same word (not rock, paper, or scissors, game will still return "draw")._

## Support and contact details

_If you run into any issues or have questions, ideas or concerns, please contact Alyssa Moody at alyssanicholemoody@gmail.com_

## Technologies Used

_Languages: HTML, CSS, C#_
_Frameworks: Nancy, .Net_

### License

*MIT license Agreement*

Copyright (c) 2017 **_Alyssa Moody_**
