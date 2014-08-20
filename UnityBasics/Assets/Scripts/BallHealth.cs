using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {

	public float maxFallDistance = -10;

	void Update () 
	{
	if (transform.position.y <= maxFallDistance) 
		{
			Application.LoadLevel("Level01");
		}
	}
}
