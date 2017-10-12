using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueAttack : MonoBehaviour 
{
	[SerializeField]
	private GameObject rogueFireObject;

	[SerializeField]
	private GameObject rogueBlastObject;

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.N))
		{
			Instantiate(rogueFireObject, transform.position, transform.rotation);
		}

		if(Input.GetKeyUp(KeyCode.M))
		{
			Instantiate(rogueBlastObject, transform.position, transform.rotation);
		}
	}
}
