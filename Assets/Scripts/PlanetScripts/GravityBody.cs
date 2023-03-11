using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof (Rigidbody))]
public class GravityBody : MonoBehaviour {

	[SerializeField]
	GravityAttractor planet;

	Rigidbody rigidbody;
	
	void Awake() {
		rigidbody = GetComponent<Rigidbody>();

		// Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
		rigidbody.useGravity = false;
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
	}
	
	void FixedUpdate() {
		// Allow this body to be influenced by planet's gravity
		planet.Attract(rigidbody);
	}
}