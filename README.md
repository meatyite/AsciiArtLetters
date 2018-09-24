# AsciiArtLetters

# How to add to your project 
## In C#
Download and unzip the zip file from this github page <br />
add an external dll reference in your IDE <br />
### Test the library
make a Console project named "testasciilib" (without quotation marks) and type in the following <br />
```
using System;
using AsciiArtLetters;

namespace testasciilib
{
    class MainClass
    {
        public static void Main(string[] args)
        {
		string lowerA = AsciiArtLetters.GraffitiL.a();
		Console.WriteLine(lowerA);  
        }
    }
}
```
now run the program.
## In other programming languages
### Python (Windows only)
Download and unzip the zip file from this github page <br />
add the dll to your project's folder (from AsciiArtLetters-master/AsciiArtLetters/bin/Release)
#### Test the library
```
import ctypes

asciiartletters = ctypes.CDLL('AsciiArtLetters.dll')

# test the dll

lowerA = asciiartletters.GraffitiL.a()

print lowerA
```
(open an issue on this github repo and tell me if this works)

