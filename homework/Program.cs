string[] FillUserArray(string message, int size)
{
    string[] userArr = new string[size];
for(int i=0; i<size; i++){
        Console.WriteLine($"{message} {i + 1}:");
        userArr[i] = Console.ReadLine();
    }
    return userArr;
}


int sizeOfWords=3;
string[] userWordsArray = FillUserArray("Введите строку элемента массива №", 5);