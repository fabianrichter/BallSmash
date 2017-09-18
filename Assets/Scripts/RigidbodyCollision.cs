using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyCollision : MonoBehaviour {

	public GameObject replacementObject;
	public Rigidbody ball;

	void OnCollisionEnter (Collision col) {
		if (col.collider.name == "Ball(Clone)") {
			GameObject.Instantiate (replacementObject, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}
