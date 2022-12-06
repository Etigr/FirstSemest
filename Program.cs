string[] UserArray()
{
  Console.Write($"Введи количество элементов массива: ");
  int ElemenArr = Convert.ToInt32(Console.ReadLine());
  string[] ArrayUser = new string[ElemenArr];

    for (int i = 0; i < ArrayUser.Length; i++)
    {
    Console.Write($"Введи значение {i}-го элемента массива: ");
    ArrayUser[i] = Console.ReadLine();
    }
  return ArrayUser;
}
void PrintUserArray(string[] ArrayUser)
{
    Console.WriteLine($" Массив, созданный юзером: ");
    Console.Write($"[");
    for (int i = 0; i < ArrayUser.Length; i++)
    Console.Write($" {ArrayUser[i],1}, "); 
    Console.Write("\b\b] \n");
}
