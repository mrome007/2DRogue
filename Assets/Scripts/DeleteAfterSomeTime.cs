using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterSomeTime : MonoBehaviour 
{
	[SerializeField]
	private float timeTilDelete = 2.0f;

	// Use this for initialization
	private void Start () 
	{
		Destroy(this.gameObject, timeTilDelete);	
	}

}
