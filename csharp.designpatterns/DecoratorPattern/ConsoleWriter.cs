using System;

namespace DesignPatterns.Decorator
{
	public class ConsoleWriter : Writer
	{
		public override void Write(string  message)
		{
			Console.WriteLine (message);
		}
	}
}

