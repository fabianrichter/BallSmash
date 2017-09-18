using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	public float speed = 10.0F;
	public float jumpStrength = 10;

	void Start () {
		Cursor.lockState = CursorLockMode.Locked; // Makes cursor invisible
	}

	void Update () {
		float zAxis = Input.GetAxis("Vertical") * speed;     // forwards and backwards movement
		float yAxis = Input.GetAxis("Jump") * jumpStrength;  // jump
		float xAxis = Input.GetAxis("Horizontal") * speed;   // left and right movement

		xAxis *= Time.deltaTime;
		yAxis *= Time.deltaTime;
		zAxis *= Time.deltaTime;

		transform.Translate(xAxis, yAxis, zAxis);

		if (Input.GetKeyDown("escape"))
			Cursor.lockState = CursorLockMode.None;	// Makes cursor visible
	}
}
