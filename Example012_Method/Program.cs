// string Method(int count, string text)
// {
//     string result = String.Empty;
//     for(int i=0; i < count; i++ )
//     {
//         result = result + text;
//     }
//     return result;
// }
// string result = Method(10, "z");
// Console.WriteLine(result);



// for(int i = 1; i < 10; i++)
// {
//     for(int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }  



// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//                 +"ежели бы вас послали вместо нашего милого "
//                 +"инценгероде, вы бы взяли приступом согласие"
//                 +"прусского короля. Вы так красноречивы. Вы"
//                 +"дадите мне чаю?";
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text [i]}";


//     }

//     return result; 
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

int[] arr = { 1, 5, 7, 6, 3, 4, 9, 8, 2, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minPosition]) minPosition = j;
    }

    int temporrary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporrary;
}
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);