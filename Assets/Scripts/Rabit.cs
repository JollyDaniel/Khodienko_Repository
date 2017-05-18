using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabit : MonoBehaviour {

	public float speed = 5;
	Rigidbody2D rBody = null;
	SpriteRenderer sr = null;

	// Use this for initialization
	void Start () {
		rBody = this.GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {}
	
	void FixedUpdate() {
		float value = Input.GetAxis("Horizontal");

		if (Mathf.Abs (value) > 0) {
			Vector2 vel = rBody.velocity;
			vel.x = value * speed;
			rBody.velocity = vel;
		}
		if (value < 0) sr.flipX = true;
		else if (value > 0) sr.flipX = false;
	}
}
