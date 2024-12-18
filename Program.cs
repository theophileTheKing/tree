// Take user input and convert to int
Console.Write("Enter the height of your fir : ");
int number = int.Parse(Console.ReadLine() ?? string.Empty);

Console.CursorVisible = false;
bool consoleRunning = true;


while(consoleRunning == true)
{
  printFir(number, 10, 10);
}


// MARK: print fir
void printFir(int number, int posX, int posY)
{
  Console.Clear();

  // Print lines
  for(int lineCounter = 0; lineCounter < number; lineCounter++)
  {


    Console.SetCursorPosition(posX + number - lineCounter, posY + lineCounter);


    // Print columns
    for(int colCounter = 0; colCounter < lineCounter; colCounter++)
    {
      int random_number = random(16);
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("^");
      Console.ForegroundColor = (ConsoleColor)random_number;
      int random_char = random(3);
      switch(random_char)
      {
        case 0:
          Console.Write("O");
          break;
        case 1:
          Console.Write("$");
          break;
        case 2:
          Console.Write("*");
          break;
      }
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("^");
  }

  printLog(number, posX, posY);
  Thread.Sleep(165);
}

// MARK: print log
void printLog(int number, int posX, int posY){

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

    Console.SetCursorPosition(posX + number, posY + height + number);

    // Print the log with 1 or 2 chars
    if(log_width == 1)
    {
      Console.WriteLine("H");
    } else {
      Console.Write("  ");
      Console.Write("|");
      Console.Write(" ");
      Console.WriteLine("|");
    }
  }
}

int random(int value)
{
  int random_number = new Random().Next(value);
  return random_number;
}
