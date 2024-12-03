int number = 5;

// Check if user entered args
if(args.Length == 0)
{
	// Take user input and convert to int
	Console.Write("Enter the height of your fir : ");
	string? firHeightString = Console.ReadLine();
	number = int.Parse(firHeightString);
}

// Print lines
for(int lineCounter = 0; lineCounter < number; lineCounter++)
{

	// Print spaces before the ^
	for(int spaces = number-lineCounter; spaces > 0; spaces--)
	{
		Console.Write(" ");
	}

	// Print columns
	for(int colCounter = 0; colCounter < lineCounter; colCounter++)
	{
		Console.Write("^");
		Console.Write(" ");
	}
	Console.WriteLine("");
}

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

  // Log in 1 or 2 chars
  if(log_width == 1)
  {
    Console.WriteLine(" H");
  } else {
    Console.Write(" ");
    Console.Write("|");
    Console.Write(" ");
    Console.WriteLine("|");
  }
}
