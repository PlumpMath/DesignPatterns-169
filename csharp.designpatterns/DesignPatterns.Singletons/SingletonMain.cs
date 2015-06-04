using System;

namespace DesignPatterns.Singletons
{
	public class SingletonMain
	{
		public static void Main (string[] args)
		{
			var firstVersionInstance1 = SingletonFirstVersion.Instance;
			var firstVersionInstance2 = SingletonFirstVersion.Instance;

			if (firstVersionInstance1 == firstVersionInstance2) {
				Console.WriteLine ("Both objects are same \n**This is not thread safe version of Singleton**");
			}

			var secondVersionInstance1 = SingletonSecondVersion.Instance;
			var secondVersionInstance2 = SingletonSecondVersion.Instance;
			if (secondVersionInstance1 == secondVersionInstance2) {
				Console.WriteLine ("\nBoth objects are same \n**This is thread safe version of Singleton but has performance hits due to locking**");
			}

			var thirdVersionInstance1 = SingletonThirdVersion.Instance;
			var thirdVersionInstance2 = SingletonThirdVersion.Instance;
			if (thirdVersionInstance1 == thirdVersionInstance2) {
				Console.WriteLine ("\nBoth objects are same \n**This is thread safe version of Singleton with double-check locking. It has poor performance**");
			}

			var fourthVersionInstance1 = SingletonFourthVersion.Instance;
			var fourthVersionInstance2 = SingletonFourthVersion.Instance;
			if (fourthVersionInstance1 == fourthVersionInstance2) {
				Console.WriteLine ("\nBoth objects are same \n**little lazy instantiation and thread safe without locks**");
			}

			var fifthVersionInstance1 = SingletonFifthVersion.Instance;
			var fifthVersionInstance2 = SingletonFifthVersion.Instance;
			if (fifthVersionInstance1 == fifthVersionInstance2) {
				Console.WriteLine ("\nBoth objects are same \n**Fully lazy instantiation**");
			}

			var sixthVersionInstance1 = SingletonSixthVersion.Instance;
			var sixthVersionInstance2 = SingletonSixthVersion.Instance;
			if (sixthVersionInstance1 == sixthVersionInstance2) {
				Console.WriteLine ("\nBoth objects are same \n**using .NET 4's Lazy<T> type**");
			}
		}
	}
}
