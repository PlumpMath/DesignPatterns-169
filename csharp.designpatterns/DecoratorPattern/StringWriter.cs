using System;
using System.Text;

namespace DesignPatterns.Decorator
{
	public class StringWriter : Writer
	{
		StringBuilder stringBuilder = new StringBuilder ();

		public override void Write(string message)
		{
			stringBuilder.Append (message);
		}

		public override string ToString ()
		{
			return stringBuilder.ToString ();
		}
	}
}

