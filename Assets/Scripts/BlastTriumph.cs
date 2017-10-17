using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastTriumph : MonoBehaviour 
{
	public SpriteRenderer BlastSpriteRenderer;

	public void Initialize(bool success)
	{
		BlastSpriteRenderer.color = success ? Color.green : Color.red;
	}
}
