using System;

namespace DesignPatterns.Singletons
{
	public sealed class SingletonFifthVersion
	{
		private SingletonFifthVersion ()
		{
		}

		public static SingletonFifthVersion Instance { get { return InnerSingleton._singletonInstance; } }

		private class InnerSingleton
		{
			static InnerSingleton ()
			{
			}

			internal static readonly SingletonFifthVersion _singletonInstance = new SingletonFifthVersion ();
		}
	}
}

