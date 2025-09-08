@echo off
setlocal

:: Prompt for project directory name
set /p PROJ_DIR=Give a directory name to create: 

:: Prompt for template type
set /p TEMP_TYPE=Please provide the template project type you'd like to create: 

:: Check if directory exists
if exist "%PROJ_DIR%" (
    echo %PROJ_DIR% already exists, aborting
    exit /b 1
)

:: Create and enter the directory
mkdir "%PROJ_DIR%"
cd "%PROJ_DIR%"
echo Current directory: %CD%
echo %PROJ_DIR%

:: Create the project from template
dotnet new "%TEMP_TYPE%" -o "%PROJ_DIR%"

:: Create solution and add project
dotnet new sln
dotnet sln add "%PROJ_DIR%"

:: Create test project and add to solution
dotnet new xunit -o "%PROJ_DIR%.Tests"
dotnet sln add "%PROJ_DIR%.Tests"

:: Add reference from test project to main project
dotnet add "%PROJ_DIR%.Tests" reference "%PROJ_DIR%"

:: Run tests
dotnet test "%PROJ_DIR%.Tests"

endlocal
