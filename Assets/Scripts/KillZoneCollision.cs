using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZoneCollision : MonoBehaviour 
{
	private void OnTriggerEnter2D(Collider2D collidingObject)
	{
		CollisionCompareTag(collidingObject.gameObject.tag);
	}

	private void CollisionCompareTag(string tag)
	{
		switch(tag)
		{
			case "KillZone":
				Destroy(gameObject);
				break;
			default:
				break;
		}
	}
}
