using System;

namespace practice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Start:
			for (double i = 1 * 10; i >= 1; i++) {
				Console.WriteLine (i);

			}
			Console.ReadLine ();
			Console.WriteLine ();
			Console.ReadKey ();
			goto Start;
		
	}
}
}
