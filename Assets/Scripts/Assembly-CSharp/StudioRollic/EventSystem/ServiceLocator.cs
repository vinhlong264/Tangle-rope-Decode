using System;
using System.Collections.Generic;

namespace StudioRollic.EventSystem
{
	public class ServiceLocator
	{
		private static ServiceLocator _instance;

		private readonly Dictionary<Type, IGameService> services;

		public static ServiceLocator Instance => null;

		private ServiceLocator()
		{
		}

		public void Clear()
		{
		}

		public T Resolve<T>() where T : IGameService
		{
			return default(T);
		}

		public void Register<T>(T service) where T : IGameService
		{
		}

		public void Unregister<T>() where T : IGameService
		{
		}
	}
}
