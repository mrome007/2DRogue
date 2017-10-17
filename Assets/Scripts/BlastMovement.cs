using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastMovement : MonoBehaviour 
{
	/// <summary>
	///	I'm still deciding whether to use accelerated movement on blast or just keep it uniform.
	/// So I'm keeping the option to switch for now.
	/// </summary>
	public bool uniform = true;

	#region Movement information

	private Vector2 blastDirection = Vector2.right;
	private float blastMaxSpeed = 20f;
	private float blastAcceleration = 75f;
	private float blastCurrentSpeed = 0f;

	#endregion

	/// <summary>
	/// Initialize the specified direction, maxSpeed and acceleration.
	/// </summary>
	/// <param name="direction">Direction.</param>
	/// <param name="maxSpeed">Max speed.</param>
	/// <param name="acceleration">Acceleration.</param>
	public void Initialize(Vector2 direction, float maxSpeed, float acceleration)
	{
		blastDirection = direction;
		blastMaxSpeed = maxSpeed;
		blastAcceleration = acceleration;
	}

	private void Start()
	{

	}

	private void Update()
	{
		blastCurrentSpeed = uniform ? blastMaxSpeed : BlastAcceleratedMovement(blastCurrentSpeed);
		transform.Translate(blastDirection * blastCurrentSpeed * Time.deltaTime);
	}

	private float BlastAcceleratedMovement(float speed)
	{
		float result = speed;
		result = result + blastAcceleration * Time.deltaTime;
		return result;
	}
}
