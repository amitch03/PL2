{\rtf1\ansi\ansicpg1252\cocoartf1038\cocoasubrtf350
{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
\margl1440\margr1440\vieww9000\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\ql\qnatural\pardirnatural

\f0\fs24 \cf0 =  =          = =       =  =   =   =     = = = = = =        =           =      = = = = = = = \
=   =       =   =       =            =      =                        =           =                =\
=    =    =     =       =            =      =                        = = = = =                =\
=     =  =      =       =            =      =                        =           =                =\
=       =        =       =   =   =  =     = = = = = =        =           =      = = = = = = = \
\
***********************\
Mochi README \
Lamont Samuels \
***********************\
\
*********************************************************\
* Version History \
*********************************************************\
\
===========\
v1.2\
===========\
\
-  Added support for command line compiling and running a file. \
\
- Included support images with the jar file \
\
- Removed verification message when clearing the console \
\
===========\
v1.1\
===========\
\
-  Added the computeglobaladdress instruction \
\
-  Fixed the bug where the console window would not output after running in debug    mode.\
\
- Fixed the bug where the loadinagrument instruction did not load in the arguments. \
\
- Highlighted the mov instructions in the text editor panel. \
\
- Fixed the bug where the application would crash in the debugger when a step over was requested for a call instruction. \
\
- Updated the Memory tab in the debugger so now deleted memory appears in red. \
\
- Fixed bug where the global variables would not be cleared after a run execution. \
\
- Added a space to the end of the print instruction \
 \
- Updated the local variables, registers, memory fields, and global variables to have a default value of null (0). \
\
\
\
===========\
v1.0\
===========\
- Initial release.\
\
\
*********************************************************\
* Usage Instructions\
*********************************************************\
\
Extract the Mochi.zip file into a directory. Once extracted, click on the Mochi.jar file to run the application. \
\
*Note: The images folder needs to be in the same directory of the Mochi.jar file. \
\
For more information about using Mochi refer to the User Manual included with the application.  \
\
\
*********************************************************\
* Unknown Bugs/Temporary Fixes \
*********************************************************\
\
- On occasion, the console window in the main window may sometimes duplicate the already read in data or may display output from a previous run execution. \
\
	** TEMPORARY FIX** \
                - In this case just restart the Mochi application and the problem will cease 	     to exist\
\
- A file may not contain function names that are the same as an instruction key code e.g.(add, mult, print). \
\
	** TEMPORARY FIX** \
                - You need the change the name of the function and all call instructions to 	    the newly named function. \
\
- If a stack overflow appears or an infinite loops occurs it can cause the program to become unstable. \
\
	** TEMPORARY FIX** \
                - In this case just restart the Mochi application and the problem will cease 	     to exist\
\
}