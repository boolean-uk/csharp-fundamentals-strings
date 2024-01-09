// See https://aka.ms/new-console-template for more information
using csharp_fundamentals_strings.Main;
using System;

Console.WriteLine("Hello, World!");
Core a = new Core();

Console.WriteLine('|' + a.faqUrl + '|');

string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog." };

var unreadablePhrase = string.Concat(words);
System.Console.WriteLine(unreadablePhrase);