using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {
	public GameObject blackHole;
	public float gravityFactor = 1f;
	public bool released = false;

	void FixedUpdate () {
		if (released) {
			Rigidbody2D rocketrb = GetComponent<Rigidbody2D> ();
			Rigidbody2D blackHolerb = blackHole.GetComponent<Rigidbody2D> ();
			rocketrb.AddForce ((blackHole.transform.position - transform.position).normalized
			* blackHolerb.mass * gravityFactor /
			(blackHole.transform.position - transform.position).sqrMagnitude);
		}
	}
}
