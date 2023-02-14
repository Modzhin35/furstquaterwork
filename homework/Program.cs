string[] FillUserArray(string message, int size)
{
    string[] userArr = new string[size];
for(int i=0; i<size; i++){
        Console.WriteLine($"{message} {i + 1}:");
        userArr[i] = Console.ReadLine();
    }
    return userArr;
}

int CountThreeSymbolWords(string[] userArray, int wordSize)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= wordSize) count++;
    }
    return count;
}


int sizeOfWords=3;
string[] userWordsArray = FillUserArray("Введите строку элемента массива №", 5);
Console.WriteLine($"Ваш первоначальный массив [{String.Join(", ", userWordsArray)}]");
int sizeThreeWordsSymbols = CountThreeSymbolWords(userWordsArray, sizeOfWords);