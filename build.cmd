@echo off

REM Restore + Build
dotnet build "Prism.sln" --nologo || exit /b

REM Test
dotnet test "Prism.Tests" --nologo --no-build
