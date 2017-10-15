using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueMovement : MonoBehaviour 
{
	#region Inspector Fields

	/// <summary>
	/// The maximum speed.
	/// </summary>
	[SerializeField]
	private float maximumSpeed = 6.0f;

	/// <summary>
	/// The acceleration.
	/// </summary>
	[SerializeField]
	private float acceleration = 1.0f;

	/// <summary>
	/// The deceleration.
	/// </summary>
	[SerializeField]
	private float deceleration = 1.0f;

	#endregion

	#region Private Fields

	/// <summary>
	/// The horizontal speed.
	/// </summary>
	private float horizontalSpeed;

	/// <summary>
	/// The vertical speed.
	/// </summary>
	private float verticalSpeed;

	/// <summary>
	/// The movement vector.
	/// </summary>
	private Vector3 movementVector;

	#endregion

	#region Unity methods

	private void Start()
	{
		movementVector = Vector3.zero;
		horizontalSpeed = 0f;
		verticalSpeed = 0f;
	}

	private void Update()
	{
		var h = Input.GetAxisRaw("Horizontal");
		var v = Input.GetAxisRaw("Vertical");

		horizontalSpeed = GetSpeed(h, horizontalSpeed);
		verticalSpeed = GetSpeed(v, verticalSpeed);

		movementVector.x = horizontalSpeed;
		movementVector.y = verticalSpeed;
		transform.Translate(movementVector);
	}

	#endregion

	/// <summary>
	/// Gets the speed.
	/// </summary>
	/// <returns>The speed.</returns>
	/// <param name="axis">Axis.</param>
	/// <param name="speed">Speed.</param>
	float GetSpeed(float axis, float speed)
	{
		float result = speed;
		//move with acceleration
		if(axis != 0)
		{
			var resultSpeed = result + (axis * acceleration * Time.deltaTime);
			if(Mathf.Abs(resultSpeed) < maximumSpeed)
			{
				result = result + (axis * acceleration * Time.deltaTime);
			}
			else
			{
				result = maximumSpeed * axis;
			}
		}
		//stop and decelerate.
		else
		{
			var sign = Mathf.Sign(result);
			if(Mathf.Abs(result) > 0.01)
			{
				result = result + (-sign * deceleration * Time.deltaTime);
			}
			else
			{
				result = 0f;
			}
		}
		return result;
	}
}
