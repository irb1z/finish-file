Console.Clear();
Console.Write("Введите кол-во элементов:  ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
     array[i] = new Random().Next(0, 10);
     Array.Reverse(array);
Console.WriteLine(string.Join(", ", array));

Array.Reverse(array);
Console.WriteLine(string.Join(", ", array));
