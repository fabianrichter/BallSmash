using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour {

	public float strength = 10.0F;	// strength multiplier
	public int ballAmmo   = 50;		// default ball ammunition
	public Rigidbody ball;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("f") && ballAmmo > 0) {
			throwBall();
			ballAmmo--;
		}
	}

	void throwBall () {
		Rigidbody ballClone = (Rigidbody) Instantiate(ball);			// spawn prefab ball
		ballClone.transform.localPosition = transform.position;		// sets ball start coordinates relative to character

		Vector3 throwDirection = transform.GetChild(0).forward;		// direction of actual view

		ballClone.AddForce((throwDirection) * strength, ForceMode.Impulse);	// throws ball
	}
}
