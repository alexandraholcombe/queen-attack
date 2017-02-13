# Queen Attack Checker

#### _Determine if a Chess Queen Could Attack_

#### By _**Alexandra Holcombe && Caitlin Hines**_

## Description

This web application will determine if a chess queen could attack another piece horizontally, vertically, or diagonally based on two user-inputted coordinate pairs.


## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The application will only accept a coordinate integer pair within the size of the board.**
* Example Input: BANANAS
* Example Output:

**The application will only accept different coordinate pairs.**
* Example Input: Q:(1,1) P:(1,1)
* Example Output: The coordinates must be different.

**The application will output "false" if the queen and pawn are not aligned vertically, horizontally, or diagonally.**
* Example Input: Q:(1,1) P:(3,2)
* Example Output: false

**The application will output "true" if the queen and pawn are placed in the same column.**
* Example Input: Q: (1,1) P:(8,1)
* Example Output: true

**The application will output "true" if the queen and pawn are placed in the same row.**
* Example Input: Q:(1,1) P:(1,8)
* Example Output: true

**The application will output "true" if the queen and pawn are placed in the same SW-NE diagonal.**
* Example Input: Q:(2,3) P:(5,6)
* Example Output: true

**The application will output "true" if the queen and pawn are placed in the same NW-SE diagonal.**
* Example Input: Q(1,6) P:(5,2)
* Example Output: true


## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Caitlin Hines at caitlinhines@me.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe && Caitlin Hines_**
