#!/bin/bash

# Restore + Build
dotnet build "msc" --nologo || exit

# Run
dotnet run -p "msc" --no-build -- "$@"
