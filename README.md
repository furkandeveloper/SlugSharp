<p align="center">
  <img src="https://user-images.githubusercontent.com/47147484/235533294-50e23459-1943-4055-89e9-dab59593c10c.png" style="max-width:100%;" height="140" />
</p>

<p align="center">
  <a href="https://gitmoji.carloscuesta.me">
    <img src="https://img.shields.io/badge/gitmoji-%20😜%20😍-FFDD67.svg?style=flat-square" alt="Gitmoji">
  </a> 
</p>

***

| Source     | Badges                |
| :------- | :------------------------- |
| `Code Quality` | [![Maintainability](https://api.codeclimate.com/v1/badges/63101ab83504f0bbe880/maintainability)](https://codeclimate.com/github/furkandeveloper/SlugSharp/maintainability) |
| `License` | [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)  |
| `CI` | [![.NET](https://github.com/furkandeveloper/SlugSharp/actions/workflows/dotnet.yml/badge.svg?branch=master)](https://github.com/furkandeveloper/SlugSharp/actions/workflows/dotnet.yml)  |
| `Github Activity` | ![GitHub commit activity](https://img.shields.io/github/commit-activity/y/furkandeveloper/SlugSharp) ![GitHub contributors](https://img.shields.io/github/contributors/furkandeveloper/SlugSharp) ![GitHub last commit](https://img.shields.io/github/last-commit/furkandeveloper/SlugSharp) ![GitHub search hit counter](https://img.shields.io/github/search/furkandeveloper/SlugSharp/SlugSharp) ![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/furkandeveloper/SlugSharp) ![GitHub repo size](https://img.shields.io/github/repo-size/furkandeveloper/SlugSharp)|
| `Languages` | ![GitHub top language](https://img.shields.io/github/languages/top/furkandeveloper/SlugSharp) |
| `Issue Tracking` | ![GitHub issues](https://img.shields.io/github/issues/furkandeveloper/SlugSharp) ![GitHub closed issues](https://img.shields.io/github/issues-closed/furkandeveloper/SlugSharp) ![GitHub closed pull requests](https://img.shields.io/github/issues-pr-closed/furkandeveloper/SlugSharp) ![GitHub pull requests](https://img.shields.io/github/issues-pr/furkandeveloper/SlugSharp) | |

## Give a Star 🌟
If you liked the project or if **SlugSharp** helped you, please give a star.

***

### Purpose
**Slug Sharp** provides slug generator helper for dotnet

***

### How To Use?

#### Install Package
```
dotnet add package SlugSharp
```

<p align="center">
  <img src="https://user-images.githubusercontent.com/47147484/169529159-8f400ad7-922b-43f3-867f-4eeb93aa724b.png" style="max-width:100%;" height="40" />
</p>

#### Generating Slugs with a Single Parameter

```csharp
var slug = SlugGenerator.Generate("This repository provides slug generator helper for dotnet");
```

#### Generating Slugs with a Multiple Parameter

```csharp
var slug = SlugGenerator.Generate(new[] { "This repository provides slug generator helper for dotnet", "This repository provides slug generator helper for dotnet", "This repository provides slug generator helper for dotnet" });
```

<p align="center">
  <img src="https://user-images.githubusercontent.com/47147484/169529159-8f400ad7-922b-43f3-867f-4eeb93aa724b.png" style="max-width:100%;" height="40" />
</p>

#### Response
```
this-repository-provides-slug-generator-helper-for-dotnet
```
