// See https://aka.ms/new-console-template for more information

//CSharpSnack1 Dichiarare un array dei mesi e stampare tutti i mesi dell’anno in console.

using System.Runtime.CompilerServices;

string[] mesiArray = { "gennaio", "febbraio", "marzo", "aprile", "giugno", "luglio", "agosto", "settembre", "ottobre", "novembre", "dicembre" };

foreach(string mese in mesiArray)
{
    Console.WriteLine(mese);
};

int indexOfLuglio = Array.IndexOf(mesiArray,"luglio");
mesiArray[indexOfLuglio] = "";

