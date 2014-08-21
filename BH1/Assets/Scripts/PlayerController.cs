using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public bool isFalling;

	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2 (moveHorizontal * moveSpeed, rigidbody2D.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space) && isFalling == false) 
		{
			rigidbody2D.velocity = new Vector2(rigidbody.velocity.x, jumpHeight);
		}
		isFalling = true;
	}

	public void OnCollisionStay()
	{
		isFalling = false;
	}
}
