using System;
using System.Collections.Generic;
using StudioRollic.EventSystem;

public class EventBus : IGameService
{
	private static EventBus eventBus;

	private readonly Dictionary<Type, List<object>> _eventDictionary;

	private readonly Dictionary<Type, List<Action>> _noArgsEventDictionary;

	public static EventBus Instance => null;

	internal void Unsubscribe<T>()
	{
	}

	public void Initialize()
	{
	}

	public void Subscribe<T>(Action<T> action) where T : IEvent
	{
	}

	public void Subscribe<T>(Action action) where T : IEvent
	{
	}

	public void Unsubscribe<T>(Action<T> action) where T : IEvent
	{
	}

	public void Unsubscribe<T>(Action action) where T : IEvent
	{
	}

	public void Fire<T>(T payload) where T : IEvent
	{
	}

	public void Test()
	{
	}
}
