using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public float rotationSpeed = 100;

	void Update () 
	{
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime; 
		rigidbody.AddRelativeTorque (Vector3.back * rotation);

	}

}
