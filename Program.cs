Console.WriteLine("C# Loops!");

Console.WriteLine("Numbers from 0 to 1000...");

int i = 0;

while(i <= 1000) {
  Console.Write(i + " ");
  i = i + 1;
}

Console.WriteLine("Completed\n\n");

Console.WriteLine("Even numbers");

int from;
int to;
string? input;

Console.Write("Enter the first number: ");
input = Console.ReadLine();
from = Convert.ToInt32(input);
Console.Write("Enter the second number: ");
input = Console.ReadLine();
to = Convert.ToInt32(input);

for (int y = from; y < to; y++)
{
  if (y % 2 == 0){
    Console.Write(y + " ");
  }
}

Console.WriteLine("End of execution");
