using System;

namespace DesignPatterns.Decorator
{
	public class UpperCaseDecorator : WriterDecorator
	{
		public UpperCaseDecorator(Writer writer) : base(writer){}

		public override void Write (string message)
		{
			base.Write (message.ToUpper ());
		}
	}
}

