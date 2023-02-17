// Вид 1 // Что-то Возвращают

void Method1()
{
    Console.WriteLine(" Автор Дроздов А.С. drozdov_as@mail.ru ");
}

// Method1();

// Вид 2 // Что-то Принимают и Ничего не Возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21("Светик", 4);
// Method21(msg: "Тёмик", count: 4);

// Вид 3 // Что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();

// Console.WriteLine(year);

// Вид 4 // Что-то Принимают и Что-то Возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string Method4for(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

/*
string res = Method4(10, "Asdf");
Console.WriteLine(res);
res = Method4for(10, "Asdf");
Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
/**/
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
//             012345
// s[3] == r

string Replace(string text, char oldValue, char newValue){
    string result = String.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
Console.WriteLine(text);

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
/**/

/*
==============================================================================================
==============================================================================================
=== Сортировка методом Выбора

*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 9 };
int[] arr1 = arr;

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
/**/
void SelectionSortMinMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
/**/
void SelectionSortMaxMin(int[] array)
{
    for (int i = array.Length - 1; i > 0; i--)
    {
        int maxPosition = i;

        for (int j = i - 1; j >= 0; j--)
        {
            if (array[j] < array[maxPosition])
                maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
/**/
PrintArray(arr);
SelectionSortMinMax(arr);
PrintArray(arr);
SelectionSortMaxMin(arr1);
PrintArray(arr1);
