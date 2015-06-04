using System;

namespace DesignPatterns.Singletons
{
	public sealed class SingletonSecondVersion
	{
		private static SingletonSecondVersion _singletonInstance = null;

		SingletonSecondVersion ()
		{
		}

		private static readonly object _lockObject = new object ();

		public static SingletonSecondVersion Instance {
			get {
				lock (_lockObject) {
					if (_singletonInstance == null) {
						_singletonInstance = new SingletonSecondVersion ();
					}
				}
				return _singletonInstance;
			}
		}
	}
}

