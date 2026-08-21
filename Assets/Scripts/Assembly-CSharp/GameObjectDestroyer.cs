using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[DefaultExecutionOrder(-2000000000)]
public class GameObjectDestroyer : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private GameObjectEvent destroyGameObjectEvent;

	[SerializeField]
	[Header("Settings")]
	private int tickPerFrame;

	[SerializeField]
	private int destroyPerTick;

	private Queue<Object> destroyQueue;

	private int tick;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleDestroyQueue()
	{
	}

	private void OnDestroyGameObjectCallback(GameObject obj)
	{
	}
}
