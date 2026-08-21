using UnityEngine;

public class ExampleScript : MonoBehaviour
{
	[RequireInterface(typeof(IExampleInterface))]
	[SerializeField]
	private Object _referenceExample;

	[RequireInterface(typeof(IExampleInterface))]
	[SerializeField]
	private Object _scriptableReferenceExample;

	[RequireInterface(typeof(IExampleInterface))]
	public Object emptyFieldExample;

	[RequireInterface(typeof(IExampleInterface))]
	public Vector2 nonReferenceExample;

	public IExampleInterface ReferenceExample => null;

	public IExampleInterface ScriptableReferenceExample => null;
}
