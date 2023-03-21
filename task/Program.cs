string[] input = new string[]{"hello", "world", "21", "03", "2023", "!!!"};
string[] array = new string[input.GetLength(0)];

int index = 0;

for (int i = 0; i < input.GetLength(0); i++)
{
  if (input[i].Length <= 3)
  {
    //добавляе элемент
     array[index] = input[i];
     //увеличиваем счетчик эл-тов результирующего массива
     index++;
  }
}
Console.Write("Результирующий массив = ");

for (int i = 0; i < index; i++)
{
  Console.Write(array[i] + " ");
}