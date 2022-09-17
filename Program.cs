string [] array = {"Seminar", "2022", "22", "09", "18", "Work", "Wolwes", "abc", "park", "hi", "1hj"};
Console.WriteLine($"Исходный массив [{String.Join("; ", array)}]");
int size = array.Length;
string [] array_cut = new string [size];
for (int index = 0; index < size; index++)
{
    if (array[index].Length <= 3)
        {
            array_cut[index]=array[index];
        }
}
Console.WriteLine($"Массив из 3х и менее символов - [{String.Join("; ", array_cut)}]");