using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {

	public float maxSpeed = 0.5f;
	public float maxWalkSpeed = 0.5f;
	public float maxRunSpeed = 3f;
	public bool isInside;
	bool isRunning;
	bool facingRight = true;
	Animator animPlayer;

	void Start() 
	{
		animPlayer = this.gameObject.GetComponent<Animator>();
	}
	
	void FixedUpdate() 
	{
		animPlayer.SetBool("Running",isRunning);
		float move = Input.GetAxis("Horizontal");

		animPlayer.SetFloat("Speed", Mathf.Abs(move));

		GetComponent<Rigidbody>().velocity = new Vector3(move * maxSpeed, GetComponent<Rigidbody>().velocity.z);

		if (move > 0 && !facingRight)
			Flip();
		else if(move < 0 && facingRight)
			Flip();
		if(Input.GetButton("Run"))
		{
			if(isInside == false)
			{
				maxSpeed = maxRunSpeed;
				isRunning = true;
			}

		}
		else 
		{
			maxSpeed = maxWalkSpeed;
			isRunning = false;
		}
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
