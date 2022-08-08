string[] fArray = new string[10] {"Rus", "Alisa", "Programm", "37", "org", "SPb", "RZD", "->", "^-^", "C#"};
string[] sArray = new string[fArray.Length];
void FinishArray(string[] fArray, string[] sArray)
{
    int j = 0;
    for (int i = 0; i < fArray.Length; i++)
    {
    if(fArray[i].Length <= 3)
        {
        sArray[j] = fArray[i];
        j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
FinishArray(fArray, sArray);
PrintArray(sArray);