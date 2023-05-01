// See https://aka.ms/new-console-template for more information

using SlugSharp;

Console.WriteLine("Hello, World!");

var slug = SlugGenerator.Generate(new[] { "This repository provides slug generator helper for dotnet", "This repository provides slug generator helper for dotnet", "This repository provides slug generator helper for dotnet" });

var singleSlug = SlugGenerator.Generate("This repository provides slug generator helper for dotnet");

Console.WriteLine(slug);

Console.WriteLine(singleSlug);