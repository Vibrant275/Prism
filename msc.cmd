@echo off

REM Restore + Build
dotnet build "msc" --nologo || exit /b

REM Run
dotnet run -p "msc" --no-build -- %*
