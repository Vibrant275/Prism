@echo off

REM Restore + Build
dotnet build "msi" --nologo || exit /b

REM Run
dotnet run -p "msi" --no-build
