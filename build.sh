#!/bin/bash

# Restore + Build
dotnet build "Prism.sln" --nologo || exit

# Test
dotnet test "Prism.Tests" --nologo --no-build
