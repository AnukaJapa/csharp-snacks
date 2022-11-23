// See https://aka.ms/new-console-template for more information
//SNACK 2: Dichiarare un vettore(array) hard-coded di numeri. Ciclare su quel vettore e se il numero è
//pari stampare a video: “Il numero è pari” se invece il numero scelto è dispari: “Il numero è dispari”

int[] numeriArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int count = 1;
for (int i = 0; i < numeriArray.Length; i++)
{
    if (numeriArray[i] % 2 == 0)
    {
        Console.WriteLine($"Il numero {numeriArray[i]} è pari!");

    }
    else
    {
        Console.WriteLine($"Il numero {numeriArray[i]} è dispari!");
        numeriArray[i] += count;
        count += 2;
    }
};

foreach (int numero in numeriArray)
{
    Console.WriteLine(numero);
}
