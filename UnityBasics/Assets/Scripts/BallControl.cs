using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public float rotationSpeed = 100;
	public float jumpHeight = 8;
	private bool isFalling = false;
	void Update () 
	{
		//Handle ball rotation.
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime; 
		rigidbody.AddRelativeTorque (Vector3.back * rotation);

		if (Input.GetKeyDown (KeyCode.Space) && isFalling == false) 
		{
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpHeight);
		}
		isFalling = true;
	}
	public void OnCollisionStay()
	{
		isFalling = false;
	}
}
