using System;

namespace DesignPatterns.Singletons
{
	public sealed class SingletonFourthVersion
	{
		private static readonly SingletonFourthVersion _singletonInstance = new SingletonFourthVersion ();

		static SingletonFourthVersion ()
		{
		}

		private SingletonFourthVersion ()
		{
		}

		public static SingletonFourthVersion Instance {
			get {
				return _singletonInstance;
			}
		}
	}	
}

