using System;

namespace DesignPatterns.Singletons
{
	public sealed class SingletonThirdVersion
	{
		private static SingletonThirdVersion _singletonInstance = null;

		private static readonly object _lockObject = new object ();

		SingletonThirdVersion ()
		{
		}

		public static SingletonThirdVersion Instance {
			get {
				if (_singletonInstance == null) {
					lock (_lockObject) {
						if (_singletonInstance == null) {
							_singletonInstance = new SingletonThirdVersion ();
						}
					}
				}
				return _singletonInstance;
			}
		}
	}
}

