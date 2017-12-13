# Chess
C# program .net core 2.0

This program built on .NET Core 2.0 platform. To run this program someone need to install .NET Core 2.0 framework in the local. Please find the link to download the same.

https://www.microsoft.com/net/download/thank-you/dotnet-sdk-2.0.3-windows-x64-installer

The program can be run either through VS Code, Visual Studio 2017 or Command Prompt.

To run it throguh Command Prompt follow the steps
1. Go To the working directory of the project, Say the project is located in the following directroy 
   C:\Users\AP7392\Source\chess\chess\Chess\Chess
   The use cd C:\Users\AP7392\Source\chess\chess\Chess\Chess
   
 2. Now run "dotnet run" command from the prompt.
 You should get the following output 
 
A8B8C8D8E8F8G8H8
A7B7C7D7E7F7G7H7
A6B6C6D6E6F6G6H6
A5B5C5D5E5F5G5H5
A4B4C4D4E4F4G4H4
A3B3C3D3E3F3G3H3
A2B2C2D2E2F2G2H2
A1B1C1D1E1F1G1H1


Avilable Pieces, 'King, Queen, Bishop, Horse, Rook, Pawn'
Enter a piece type to move:King D6
E6,C6,D5,E5,C5,D7,C7,E7,

Since its built on a console platform so it might gives an impression that IChessBoard interface is not getting used, but I have kept a provision incase we decide to change the platform from console to windows or web based app, then we can Use DI and IoC more easily and create a robost chess app.

=============================12/13/2017================================
===============Decleration of virtual functions in BaseMoves Class======================
I have created virtual functions for Diagonal Moves, Vertical Moves and Horizontal Moves because as of now we are considering the board is empty and only one color is present, but in actual game there will be two colour and amoung them individual items has their own power based on that they can elminate another item from the board, Considering queen can eliminate anyone from the board but pawn cannot eliminate queen from the board, So these virtual functions will help us to override the functional when we will be implementing this scenario.
