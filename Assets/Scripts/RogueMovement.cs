using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueMovement : MonoBehaviour 
{
	#region Inspector Fields

	/// <summary>
	/// The speed.
	/// </summary>
	[SerializeField]
	private float speed = 5.0f;

	#endregion

	#region Private Fields

	/// <summary>
	/// The movement vector.
	/// </summary>
	private Vector3 movementVector;

	#endregion

	#region Unity methods

	private void Start()
	{
		movementVector = Vector3.zero;
	}

	private void Update()
	{
		var h = Input.GetAxisRaw("Horizontal");
		var v = Input.GetAxisRaw("Vertical");

		movementVector.x = h;
		movementVector.y = v;
		transform.Translate(movementVector * speed * Time.deltaTime);
	}

	#endregion
}
