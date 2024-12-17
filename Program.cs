int number = 5;

// Take user input and convert to int
Console.Write("Enter the height of your fir : ");
number = int.Parse(Console.ReadLine() ?? string.Empty);

Console.CursorVisible = false;
bool value = true;
while(value == true)
{
  printFir();
}

void printFir()
{
  Console.Clear();

  // Print lines
  for(int lineCounter = 0; lineCounter < number; lineCounter++)
  {

    // Print spaces before the first character
    for(int spaces = number-lineCounter; spaces > 0; spaces--)
    {
      Console.Write(" ");
    }

    // Print columns
    for(int colCounter = 0; colCounter < lineCounter; colCounter++)
    {
      int random_number = new Random().Next(16);
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("^");
      Console.ForegroundColor = (ConsoleColor)random_number;
      if(random_number < 6)
      {
        Console.Write("O");
      }
      else if(random_number < 12)
      {
        Console.Write("$");
      }
      else
      {
        Console.Write("*");
      }
    }
    // Reset the foreground color to white for the log
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("^");
  }

  printLog();

  Thread.Sleep(165);
}


void printLog()
{
  // Define the log's height and width
  int log_height = number / 4;
  int log_width = 1;
  if(number % 2 != 0)
  {
    log_width = 2;
  }

  // Print the log
  for(int height = 0; height < log_height; height++)
  {

    int log_space = (number / 2) - 1;

    for(int spaces = 0; spaces < log_space; spaces++)
    {
      Console.Write("  ");
    }

    // Print the log with 1 or 2 chars
    if(log_width == 1)
    {
      Console.WriteLine("  H");
    } else {
      Console.Write("  ");
      Console.Write("|");
      Console.Write(" ");
      Console.WriteLine("|");
    }
  }
}
