@echo off 
SET projectName=%1
SET solution=%projectName%\%projectName%.csproj  
echo %solution%
@echo on
call nuget.exe pack %solution%

