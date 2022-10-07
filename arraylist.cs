using System.Collections;

ArrayList liste = new ArrayList();
//liste.Add("Ayşe");
//liste.Add(2);
//liste.Add(true);
//liste.Add('A');

//İçerisindeki verilere erişim
//Console.WriteLine(liste[1]);

//foreach (var item in liste)
//   Console.WriteLine(item);

//AddRange - 1 den fazla elamanı topluca ekleme
Console.WriteLine("***** Add Range *****");

//string[] renkler = {"kırmızı","sari","yesil"};
List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};

//liste.AddRange(renkler);
liste.AddRange(sayılar);

foreach (var item in liste)
    Console.WriteLine(item);

//Sort
Console.WriteLine("***** Sort *****");
liste.Sort();

foreach (var item in liste)
    Console.WriteLine(item);

// Binary Search
Console.WriteLine("***** Binary Search *****");
Console.WriteLine(liste.BinarySearch(9));

//Reverse
Console.WriteLine("***** Reverse *****");
liste.Reverse();

foreach (var item in liste)
    Console.WriteLine(item);

//Clear
liste.Clear();
Console.WriteLine("***** Clear *****");

foreach (var item in liste)
    Console.WriteLine(item);
