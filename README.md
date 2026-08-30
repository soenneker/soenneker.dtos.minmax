[![](https://img.shields.io/nuget/v/soenneker.dtos.minmax.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.minmax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.minmax/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.minmax/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.minmax.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.minmax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.minmax/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.minmax/actions/workflows/codeql.yml)

# Soenneker.Dtos.MinMax

A serializable pair of decimal bounds for APIs and configuration models that represent a minimum and maximum.

## Install

```bash
dotnet add package Soenneker.Dtos.MinMax
```

## Usage

```csharp
using Soenneker.Dtos.MinMax;

var allowedPrice = new MinMax
{
    Min = 10.00m,
    Max = 75.50m
};

bool isAllowed = price >= allowedPrice.Min && price <= allowedPrice.Max;
```

It serializes with the property names `min` and `max` under both `System.Text.Json` and Newtonsoft.Json.

```json
{
  "min": 10.00,
  "max": 75.50
}
```

`MinMax` is a transport model, not an interval implementation. It does not enforce `Min <= Max`, perform containment checks, or normalize reversed bounds; validate those rules in the consuming domain when they matter.
