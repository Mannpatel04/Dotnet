//Why while loops?:- Because we don't know the exact number of iterations in advance.
//                   while loop is ideal when the exit condition is dynamic.



class guessinggame
{
	public static void Main(string[] args)
	{
		Random random  = new Random();
		int secretenum = random.Next(1,101);
		int guess = 0;

		Console.WriteLine("Guess a number between 1 to 100");

        while (guess!=secretenum)
        {
			guess = Convert.ToInt32(Console.ReadLine());

			if (guess < secretenum)
			{
				Console.WriteLine("Too low!");
			}
			else if (guess > secretenum)
			{
				Console.WriteLine("Too High!");
			}
			else
			{
				Console.WriteLine("Right Guesssss!!!!!");
			}
        }
	}

}