// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

#region List
var list = new List<string>();
list.Add("Ahmet");
list.Add("Yılmaz");
list.Remove("Ahmet");
list[list.Count - 1] = "Mehmet";

foreach (var item in list)
{
    Console.WriteLine(item);
} 
#endregion

Console.WriteLine();

#region ArrayList

var arrayList = new ArrayList();

arrayList.Add("Metin");
arrayList.Add(1);
arrayList.Add(true);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}
#endregion

Console.WriteLine();

#region Dictionary
var dictionary = new Dictionary<int, string>();

dictionary.Add(1, "Ahmet");
dictionary.Add(2, "Yılmaz");

foreach (var item in dictionary)
{
    //Key,value çiftleri şeklinde elemanları tutar
    Console.WriteLine($"Id:{item.Key} name:{item.Value}");
} 
#endregion

Console.WriteLine();

#region SortedList
var sortedList = new SortedList<int, string>();

sortedList.Add(5, " İlk eklenen eleman");
sortedList.Add(2, " İkinci eklenen eleman");
sortedList.Add(4, " Üçüncü eklenen eleman");
sortedList.Add(1, " Dördüncü eklenen eleman");
sortedList.Add(3, " Beşinci eklenen eleman");

foreach (var item in sortedList)
{
    //Key değerine göre sıralar
    Console.WriteLine(item.Key + " " + item.Value);
} 
#endregion

Console.WriteLine();

#region Queue
var queue = new Queue<int>();

queue.Enqueue(5);
queue.Enqueue(1);
queue.Enqueue(3);
queue.Enqueue(2);
queue.Enqueue(4);

foreach (var item in queue)
{
    Console.WriteLine(item);
}

Console.WriteLine();
var x = queue.Dequeue();

Console.WriteLine("silinen eleman: " + x);

Console.WriteLine("Listenin Yeni hali:");

foreach (var item in queue)
{
    //Eklenme sırasına göre sıralar,dequeue metodu ilk elemanı siler ve geri o elemanı döner
    Console.WriteLine(item);
}
#endregion

Console.WriteLine();

#region Stack

var stack = new Stack<string>();
stack.Push("İlk eklenen eleman");
stack.Push("İkinci eklenen eleman");
stack.Push("Üçüncü eklenen eleman");
stack.Push("Dördüncü eklenen eleman");

var a = stack.Pop(); //ilk elemanı listeden çıkarır ve geri döner

Console.WriteLine("\nSilinen eleman: " + a + "\n");

foreach (var item in stack)
{
    //Last in first out son eklenen eleman listenin ilk elemanıdır
    Console.WriteLine(item);
}
#endregion

Console.WriteLine();

#region Hashset

var hashset = new HashSet<string>();
hashset.Add("ahmet");
hashset.Add("ahmet");
hashset.Add("ahmet");
hashset.Add("ahmet");
hashset.Add("ahmet");
hashset.Add("Mehmet");
hashset.Add("Mehmet");
hashset.Add("Mehmet");
hashset.Add("Mehmet");
hashset.Add("Mehmet");
hashset.Add("Mehmet");

foreach (var item in hashset)
{
    //içinde tekrar eden elemanları elemanları tekrarsız tutar
    Console.WriteLine(item);
}

#endregion