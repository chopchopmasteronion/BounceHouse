using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {
	
	public Transform coinEffect;
	private Object effect;

	void OnTriggerEnter (Collider info) 
	{
	if (info.tag == "Player")
		{
			effect = Instantiate(coinEffect, transform.position, transform.rotation);

			Destroy(gameObject);

			Destroy((effect as Transform).gameObject, 3);
		}
	}
}
