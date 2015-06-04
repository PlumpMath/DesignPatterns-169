using System;

namespace DesignPatterns.Decorator
{
	public class WriterApp
	{
		public static void Main (string[] args)
		{
			StringWriter writer = new StringWriter ();
			UpperCaseDecorator decorator = new UpperCaseDecorator (writer);
			decorator.Write ("this is decorator pattern!!");
			Console.WriteLine (writer.ToString ());

			OffensiveWordFilter offensiveWordDecorator = new OffensiveWordFilter (new ConsoleWriter ());
			offensiveWordDecorator.Write ("You stupid , this is bullshit");
		}
	}
}
