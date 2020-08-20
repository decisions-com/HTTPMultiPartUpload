echo off
@echo Building with MsBuild

REM Set Path to MSBUILD.exe here

echo Running: "%programfiles(x86)%\MSBuild\14.0\bin\msbuild.exe" build.proj
"%programfiles(x86)%\MSBuild\14.0\bin\msbuild.exe" build.proj

pause
rem net stop "Service Host Manager Watcher"
rem net stop "Service Host Manager"
rem copy .\HTTPMultiPartUpload.zip "c:\Program Files\Decisions\Decisions Services Manager\CustomModules" /Y
rem net start "Service Host Manager"
pause
