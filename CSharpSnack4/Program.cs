// See https://aka.ms/new-console-template for more information

// Fate estrarre dal PC un numero casuale e decretate se
// questo numero è un multiplo di 3 o meno.

//Chiedete poi all’utente di indovinare se il numero estratto
//dal PC è un multiplo di 3 o meno facendogli scrivere “Si” o “No”
//(fate in modo che l’utente se scrive anche “si” o “no” oppure “sI” o
//“nO” sono tutte contemplate come opzioni. In tutti gli altri casi
//che non sono si o no, richiedete l’opzione corretta [sanificazione
//dell’input]).


//Random generateNumberRandom = new Random();
//float randomFloatNumber = generateNumberRandom.NextSingle();
//int integerRandom = (int)(randomFloatNumber * 10);
//Console.WriteLine(randomFloatNumber);
//Console.WriteLine(integerRandom);
Console.WriteLine("-----------------------------------------");

Random generatoreNumeroRandom = new Random();
int numeroInteroRandom = generatoreNumeroRandom.Next(0, 10);
bool multiplo = false;


Console.WriteLine(numeroInteroRandom);
int divisore = int.Parse(Console.ReadLine());

if (numeroInteroRandom % divisore == 0)
{
    multiplo = true;
}



bool inputValidità = false;
bool vinto = false;

do
{
    Console.WriteLine("indovina se il numero casuale è multiplo di 3 o meno e scrivi si o no");

    string utenteIndovina = Console.ReadLine().ToLower();

    if (utenteIndovina == "si")
    {
        inputValidità = true;

        if (multiplo)
        {
            Console.WriteLine("Hai vinto!");
            vinto = true;
        }
        else
        {
            Console.WriteLine("Hai perso!");

        }


    }
    else if (utenteIndovina == "no")
    {
        inputValidità = true;

        if (multiplo)
        {
            Console.WriteLine("Hai perso!");
        }
        else
        {
            Console.WriteLine("Hai vinto!");
            vinto = true;
        }

    }
    else
    {
        inputValidità = false;
        Console.WriteLine("non hai inserito input giusto prova ancora!");
    }

} while (!inputValidità && !vinto);

