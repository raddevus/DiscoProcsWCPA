#!/bin/bash
echo "Give a directory name to create:"
read PROJ_DIR
echo "Please provide the template project type you'd like to create"
read TEMP_TYPE
ORIG_DIR=$(pwd)
[[ -d $PROJ_DIR ]] && echo $PROJ_DIR already exists, aborting && exit
mkdir $PROJ_DIR
cd $PROJ_DIR
pwd
echo "$PROJ_DIR"
## exit 0
dotnet new "$TEMP_TYPE" -o "$PROJ_DIR" 
dotnet new sln
dotnet sln add "$PROJ_DIR" 
dotnet new xunit -o "$PROJ_DIR".Tests
dotnet sln add "$PROJ_DIR".Tests
dotnet add "$PROJ_DIR".Tests reference $PROJ_DIR 
dotnet test *.Tests
