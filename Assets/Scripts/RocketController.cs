using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketController : MonoBehaviour {
	public GameObject blackHole;
	public GameObject planet;
	public GameObject moon;
	public Slider powerslider;
	public Slider Thetaslider;
	public Slider Phislider;
	public Toggle firebutton;
	public float gravityFactor = 1f;
	public bool released = false;
	public bool placement = true;
	public float Theta = 0f;
	public float Phi = 0f;
	public float power = 1f;

	void FixedUpdate () {
		if (placement) {
			var p1 = planet.transform.TransformPoint(0, 0, 0);
			var p2 = planet.transform.TransformPoint(1, 1, 0);
			var w = 5.5*(p2.x - p1.x);
			Theta = (Mathf.PI/180f)*Thetaslider.value;
			Phi = Phislider.value;
			Vector3 Rad = new Vector3((float)w*Mathf.Cos(Theta), (float)w*Mathf.Sin(Theta), 0);

			transform.position = planet.transform.position + Rad;
			Quaternion temp = transform.rotation;
			temp.eulerAngles = new Vector3(0,0,Phi);
			transform.rotation = temp;

			Rigidbody2D rocketrb = GetComponent<Rigidbody2D> ();
			rocketrb.velocity = Vector2.zero;
				
			// assigning key strokes
			if (Input.GetKey (KeyCode.LeftArrow)) {
				Theta += .1f;
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				Theta += -.1f;
			}
			if (Input.GetKey (KeyCode.UpArrow)) {
				Phi += 1f;
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				Phi += -1f;
			}

			if (firebutton.isOn) {
				Vector3 boost = new Vector3 ((float)-1f * Mathf.Sin ((Phi * 3.1415f) / 180f), (float)1f * Mathf.Cos ((Phi * 3.1415f) / 180f), 0) * 10 * powerslider.value;
				rocketrb.AddForce (boost);
				// rocketrb.velocity = boost;
				placement = false;
				released = true;
			}
				
			if (Input.GetKey (KeyCode.Space)) {
				Vector3 boost = new Vector3 ((float)-1f*Mathf.Sin((Phi * 3.1415f) / 180f), (float)1f*Mathf.Cos((Phi * 3.1415f) / 180f), 0)*10*powerslider.value;
				rocketrb.AddForce (boost);
				// rocketrb.velocity = boost;
				placement = false;
				released = true;
			}

		}

		if (released) {
			if (Input.GetKey (KeyCode.X)) {
				placement = true;
				released = false;
			}
			if (firebutton.isOn == false) {
				placement = true;
				released = false;
			}
			Rigidbody2D rocketrb = GetComponent<Rigidbody2D> ();
			Rigidbody2D blackHolerb = blackHole.GetComponent<Rigidbody2D> ();
			Rigidbody2D moonrb = moon.GetComponent<Rigidbody2D> ();
			rocketrb.AddForce ((blackHole.transform.position - transform.position).normalized
				* blackHolerb.mass * gravityFactor /
				(blackHole.transform.position - transform.position).sqrMagnitude);
			rocketrb.AddForce ((moon.transform.position - transform.position).normalized
				* moonrb.mass * gravityFactor /
				(moon.transform.position - transform.position).sqrMagnitude);
		}
	}

	void Fire()
	{
		
	}
}
