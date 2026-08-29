[![](https://img.shields.io/nuget/v/soenneker.dtos.minmax.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.minmax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.minmax/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.minmax/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.minmax.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.minmax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.minmax/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.minmax/actions/workflows/codeql.yml)

# Soenneker.Dtos.MinMax

Defines an inclusive decimal interval with minimum and maximum bounds.

## Install

```bash
dotnet add package Soenneker.Dtos.MinMax
```

## What you get

- `MinMax` — Defines an inclusive decimal interval with minimum and maximum bounds.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `MinMax.Min` | Inclusive lower bound of the interval. | Inclusive lower bound of the interval. |
| `MinMax.Max` | Inclusive upper bound of the interval. | Inclusive upper bound of the interval. |
