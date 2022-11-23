// See https://aka.ms/new-console-template for more information
//SNACK3
//Chiedere all’utente di inserire 2 parole e informare l’utente quale è la parola più lunga.
//Ripetere questo task fintanto che l’utente lo desidera.

bool ripetere = false;

do
{
    Console.WriteLine("inserisci la prima parola");
    string primaParola = Console.ReadLine();

Console.WriteLine("inserisci la seconda parola");
string secondaParola = Console.ReadLine();


if (primaParola.Length > secondaParola.Length)
{
    Console.WriteLine($"prima parola {primaParola} è più lunga");
}
else if (primaParola.Length == secondaParola.Length)
{
    Console.WriteLine("entrambi hanno lunghezza uguale");
    }
    else
{
    Console.WriteLine($"seconda parola {secondaParola} è più lunga");
}


Console.WriteLine("vuoi ripetere la procedura? rispondi si o no");
string rispostaRipetere = Console.ReadLine().ToLower();

if (rispostaRipetere == "si")
{
    ripetere = true;
}
else if (rispostaRipetere == "no")
{
    ripetere = false;
}
else
{
    Console.WriteLine("non hai inserito si o no!");
}

} while (ripetere) ;


