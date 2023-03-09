int ArrayLen(string[] array)
{
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) count++;
        }
        return count;
    }
}

string[] GenerateNewArray(string[] array, int count)
{
    string[] newArray = new string[count];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newArray.Length - count] = array[i];
            count--;
        }
    }
    return newArray;
}

void Printarray(string[] array, int number)
{
    System.Console.WriteLine("Исходный массив: " + "[{0}]", string.Join(", ", array));
    System.Console.WriteLine("Итоговый массив: " + "[{0}]", string.Join(", ", GenerateNewArray(array, number)));
}


string[] strarray = { "hello", "my", "world", ":-)", "2", "!" };
string[] strarray2 = { "1234", "1567", "-2", "computer science", "355" };
string[] strarray3 = { "Russia", "Moscow", "Kazan", "Omsk" };


int arrLen = ArrayLen(strarray);
Printarray(strarray, arrLen);
int arrLen2 = ArrayLen(strarray2);
Printarray(strarray2, arrLen2);
int arrLen3 = ArrayLen(strarray3);
Printarray(strarray3, arrLen3);