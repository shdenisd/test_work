string[] CreateRandomArrayOfStrings(int minArray, int maxArray, int minString, int maxString)
{
    int length_of_array = new Random().Next(minArray, maxArray + 1);
    string[] array = new string[length_of_array];

    string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    
    for (int i = 0; i < length_of_array; i++)
    {
        int length_of_string = new Random().Next(minString, maxString + 1);
        string RandomStr = new string(' ', length_of_string);
        char[] randomStrInChar = RandomStr.ToCharArray();
        
        for (int j = 0; j < length_of_string; j++)
        {
            int randomLetter = new Random().Next(0, 33);
            randomStrInChar[j] = alphabet[randomLetter];
        }

        RandomStr = new string(randomStrInChar);
        array[i] = RandomStr;
    }

    return array;
}

void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

/*
void Filtration(ref string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) counter++;
    }
    if (counter == 0)
    {
        System.Console.WriteLine();
        System.Console.Write("Таких элементов нету");
        return;
    }

    string[] newArray = new string[counter];
    counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[counter] = array[i];
            counter++;
        }
    }

    array = newArray;
}
*/


string[] array = CreateRandomArrayOfStrings(5, 10, 1, 15);
printArray(array);
//Filtration(ref array);
System.Console.WriteLine();
printArray(array);