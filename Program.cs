string[] arr = { "hello", "2 ", "world", ":-)" };
string[] arr1 = { "1234", "1567", "-2", "computer science"};
string[] arr2 = { "Russia", "Denmark ", "Kazan"};
void Print(string[] array)
{

    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();   
}
Print(arr);
Print(arr1);
Print(arr2);
