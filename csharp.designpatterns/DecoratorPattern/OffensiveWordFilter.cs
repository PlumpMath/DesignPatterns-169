using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Decorator
{
	public class OffensiveWordFilter : WriterDecorator
	{
		public List<string> offensiveWords = new List<string>
		{
			"stupid",
			"idiot",
			"goddamn",
			"bullshit"
		};

		public OffensiveWordFilter(Writer writer) : base(writer){}

		public override void Write (string message)
		{
			base.Write (ReplaceOffensiveWords(message));
		}

		public string ReplaceOffensiveWords(string message)
		{
			return string.Join(" ", message.Split(' ')
				.Select(w => offensiveWords.Contains(w) ? w[0] + new String('*', w.Length - 1) : w));
		}
	}
}

