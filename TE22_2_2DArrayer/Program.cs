int[,] map = new int[10, 10];


map[1, 0] = 1;

int count = 0;

for (int y = 0; y < map.GetLength(1); y++)
{
  for (int x = 0; x < map.GetLength(0); x++)
  {
    Console.Write(map[x, y]);
    count++;
  }
  Console.WriteLine();
}

Console.WriteLine("\n" + count);


// char[] letters = { 'X', 'O', 'O', 'O', 'O', 'O', 'X' };

// for (int i = 0; i < map.Length; i++)
// {
//   Console.Write(map[i]);
// }



Console.ReadLine();