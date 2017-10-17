using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour 
{	
	/// <summary>
	/// Blast type. Blast will have different
	/// type that lets it transform into a 
	/// different projectile. For now just have
	/// a default.
	/// </summary>
	public enum BlastType
	{
		Default,
	}

	#region Blast Characteristics

	//These will be set when Instantiating the Blast Prefab.

	public BlastType Type = BlastType.Default;
	public bool SuccessfulBlast = false;
	public Vector2 Direction = Vector2.right;
	public float Scale = 1f;
	public float Speed = 1f;

	#endregion

	#region Blast components

	//These are the components in charge of transforming the
	//blast prefab. Instead of doing all the actions in this
	//do them somewhere else, such as movement and transformation.

	private BlastMovement blastMovement;
	private BlastTriumph blastTriumph;
	private BlastTransform blastTransform;

	#endregion 
	private void Awake()
	{
		blastMovement = GetComponent<BlastMovement>();
		blastTriumph = GetComponent<BlastTriumph>();
		blastTransform = GetComponent<BlastTransform>();
	}
}
