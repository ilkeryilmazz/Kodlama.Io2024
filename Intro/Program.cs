// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
float amount = 100000;

Console.WriteLine(amount);

//variables --> camelCase
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Sisteme giriş yap");
}




string[] loans = {"Kredi 1", "Kredi 2","Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6"};
//string[] loans2 = new string[6];
//loans2[0]="Kredi 1";

//for (int i = 0; i < loans.Length; i++)
//{
//    Console.WriteLine(loans[i]);
//}






CourseManager courseManager = new();

courseManager.GetAll();

var data = courseManager.GetAll();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i].Name + " / " + data[i].Price);
}


Console.WriteLine("Kod bitti");
