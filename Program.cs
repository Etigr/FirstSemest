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
void ArrayThreeElenent(string[] ArrayUser)
{
  string[] NewArray = new string[ArrayUser.Length];
// Console.WriteLine($"");
Console.WriteLine($"Выборка элементов массива не более 3 символов:");
Console.Write($"[");
  for (int i = 0; i < ArrayUser.Length; i++)
    if (ArrayUser[i].Length < 4)
    {
      NewArray[i] = ArrayUser[i];
      Console.Write($" {NewArray[i],1}, ");
    }
    Console.Write("\b\b] \n");
}
string[] ChallengeArr = UserArray();
PrintUserArray(ChallengeArr);
ArrayThreeElenent(ChallengeArr);