echo "Please type only one number for the major version of your dotnet 8 or 9."
echo "This will allow us to copy the correct CpSysInfo.dll to your project."
read DOTNET_VER 
rm -rf GetEnvWebApi/libs
mkdir GetEnvWebApi/libs
cp ../../chpt_002/CpSysInfo/CpSysInfo/bin/Debug/net"$DOTNET_VER".0/CpSysInfo.dll GetEnvWebApi/libs/ 
