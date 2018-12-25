using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMediator : MonoBehaviour
{

	private static InputMediator _commonInputMediator;

	public static Vector2 GetMovementInput()
	{
		return _commonInputMediator.MovementInput;
	}

	public static bool GetFireInput()
	{
		return _commonInputMediator.FireInput;
	}
	
	private Vector2 MovementInput;
	private bool FireInput;

	[SerializeField] private bool UseKeyboardInput = true;
	
	// Use this for initialization
	void Awake ()
	{
		_commonInputMediator = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (UseKeyboardInput)
		{
			MovementInput = new Vector2(Input.GetAxis("Horizontal1"), Input.GetAxis("Vertical1"));
			FireInput = Input.GetAxis("Fire1") > 0.5f;
		}
	}

	public void SetMovementInput(Vector2 Input)
	{
		MovementInput = Input;
	}

	public void SetFireInput(bool Input)
	{
		FireInput = Input;
	}
}
