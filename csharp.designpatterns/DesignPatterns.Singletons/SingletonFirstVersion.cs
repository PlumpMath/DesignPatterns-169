using System;

namespace DesignPatterns.Singletons
{
	public sealed class SingletonFirstVersion
	{
		private static SingletonFirstVersion _singletonInstance = null;

		SingletonFirstVersion ()
		{
		}

		public static SingletonFirstVersion Instance {
			get {
				if (_singletonInstance == null) {
					_singletonInstance = new SingletonFirstVersion ();
				}
				return _singletonInstance;
			}
		}
	}
}

