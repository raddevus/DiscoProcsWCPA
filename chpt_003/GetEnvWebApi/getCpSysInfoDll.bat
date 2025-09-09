@echo off
echo Please type only one number for the major version of your dotnet 8 or 9.
echo This will allow us to copy the correct CpSysInfo.dll to your project.
set /p DOTNET_VER=Enter version number (8 or 9): 

REM Remove the libs directory if it exists
IF EXIST GetEnvWebApi\libs (
    rmdir /s /q GetEnvWebApi\libs
)

REM Create the libs directory
mkdir GetEnvWebApi\libs

REM Copy the correct DLL based on the version
copy "..\..\chpt_002\CpSysInfo\CpSysInfo\bin\Debug\net%DOTNET_VER%.0\CpSysInfo.dll" GetEnvWebApi\libs\

