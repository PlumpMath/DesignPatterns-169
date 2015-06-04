using System;

namespace DesignPatterns.Decorator
{
	public abstract class  WriterDecorator : Writer
	{
		protected Writer writer;

		public WriterDecorator(Writer writer)
		{
			this.writer = writer;
		}

		public override void Write (string message)
		{
			writer.Write (message);
		}
	}
}

