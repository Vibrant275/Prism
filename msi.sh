#!/bin/bash


# Restore + Build
dotnet build "msi" --nologo || exit

# Run
dotnet run -p "msi" --no-build
