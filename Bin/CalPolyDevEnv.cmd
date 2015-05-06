rem *************************************** PROJECT ***********************************************************

set CALPOLY_ROOT=C:\CalPoly\PL2
set CALPOLY_BIN=%CALPOLY_ROOT%\bin
set COMPILER_ROOT=%CALPOLY_ROOT%\MiniCompiler
set COMPILER_SRC=%COMPILER_ROOT%\Src
set COMPILER_BIN=%COMPILER_ROOT%\Bin

rem *************************************** .NET **************************************************************

set DOTNET_TOOLS=C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools
set DOTNET_ROOT=c:\Windows\Microsoft.NET\Framework\v4.0.30319

rem *************************************** REFLECTOR *********************************************************

set REFLECTOR_ROOT=%CALPOLY_ROOT%\Reflector

rem *************************************** ANTLR *************************************************************

set ANTLR_VERSION=3.5.0.2
set ANTLR_ROOT=%CALPOLY_ROOT%\ANTLR\ANTLR_%ANTLR_VERSION%\Tool
set ANTLR_EXE=antlr3.exe

rem **************************************** PATH *************************************************************

set PATH=%ANTLR_ROOT%;%DOTNET_ROOT%;%DOTNET_TOOLS%;%REFLECTOR_ROOT%;%CALPOLY_BIN%;%PATH%

