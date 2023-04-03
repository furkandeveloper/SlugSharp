// See https://aka.ms/new-console-template for more information

using SlugSharp;

Console.WriteLine("Hello, World!");

var slug = SlugGenerator.Generate(new[] { "C# ile Slug Oluşturma", "C# ile Slug Oluşturma", "C# ile Slug Oluşturma" });

var singleSlug = SlugGenerator.Generate("Benim uygulamam nasıl da güzel slug üretiyor beeğğğ");

Console.WriteLine(slug);

Console.WriteLine(singleSlug);