<p align="center">
  <img src="https://user-images.githubusercontent.com/47147484/235533294-50e23459-1943-4055-89e9-dab59593c10c.png" style="max-width:100%;" height="140" />
</p>

<p align="center">
  <a href="https://gitmoji.carloscuesta.me">
    <img src="https://img.shields.io/badge/gitmoji-%20😜%20😍-FFDD67.svg?style=flat-square" alt="Gitmoji">
  </a> 
</p>

***

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