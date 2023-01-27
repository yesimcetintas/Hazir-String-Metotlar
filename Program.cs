﻿string degisken = "Dersimiz CSharp, hoşgeldiniz!";
string degisken2 = "CSharp";

// Length
Console.WriteLine(degisken.Length);

// ToUpper, ToLower
Console.WriteLine(degisken.ToLower());
Console.WriteLine(degisken.ToUpper());

// Concat
Console.WriteLine(String.Concat(degisken,"Merhaba"));

// Compare, CompareTo
Console.WriteLine(degisken.CompareTo(degisken2)); //-1,0,1
Console.WriteLine(String.Compare(degisken,degisken2,true));
Console.WriteLine(String.Compare(degisken,degisken2,false));

// Contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("!"));
Console.WriteLine(degisken.StartsWith("d"));

// IndexOf
Console.WriteLine(degisken.IndexOf("CS")); //değer bulamadığında -1 döner.

// Insert
Console.WriteLine(degisken.Insert(0,"Merhaba "));

//LastIndexOf
Console.WriteLine(degisken.LastIndexOf("i"));

//PadLeft, PadRight
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

//Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,1));

// Replace
Console.WriteLine(degisken.Replace("CSharp","C#"));
Console.WriteLine(degisken.Replace(' ','*'));

//Split
Console.WriteLine(degisken.Split(' ')[1]);

//Substring
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,3));