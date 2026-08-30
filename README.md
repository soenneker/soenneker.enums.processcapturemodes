[![](https://img.shields.io/nuget/v/soenneker.enums.processcapturemodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.processcapturemodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.processcapturemodes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.processcapturemodes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.processcapturemodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.processcapturemodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.processcapturemodes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.processcapturemodes/actions/workflows/codeql.yml)

# Soenneker.Enums.ProcessCaptureModes

A string-backed enum-value type for selecting how a process runner handles child-process output.

## Install

```bash
dotnet add package Soenneker.Enums.ProcessCaptureModes
```

## Usage

```csharp
using Soenneker.Enums.ProcessCaptureModes;

ProcessCaptureMode mode = ProcessCaptureMode.Inherit;
string wireValue = mode.Value; // "Inherit"

if (ProcessCaptureMode.TryFromValue(input, out ProcessCaptureMode? parsed))
{
    mode = parsed;
}
```

The only defined value is `Inherit`, which tells a consuming process runner to leave output handling with the parent or invoking environment instead of selecting a package-defined capture strategy.

`System.Text.Json` serializes the type as `"Inherit"` and restores that value to the shared static instance. `FromValue` throws for unknown input; use `TryFromValue` at configuration or request boundaries. `FromName` and `TryFromName` are also generated.

This package only carries the mode. It does not start processes, redirect streams, buffer output, or define whether standard output and standard error are merged. Those semantics must be implemented and documented by the process runner receiving the value.
