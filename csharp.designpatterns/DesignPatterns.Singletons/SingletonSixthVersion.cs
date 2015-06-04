using System;

namespace DesignPatterns.Singletons
{
	public sealed class SingletonSixthVersion
	{
		private static readonly Lazy<SingletonSixthVersion> _lazyInstance =
			new Lazy<SingletonSixthVersion> (() => new SingletonSixthVersion ());

		public static SingletonSixthVersion Instance { 
			get { 
				return _lazyInstance.Value; 
			}
		}

		SingletonSixthVersion ()
		{
		}
	}
}

