using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Paddle paddle;

	private bool hasStarted;
	private Vector3 paddletoBallVector;
	// Use this for initialization
	void Start () {
		paddletoBallVector = this.transform.position - paddle.transform.position;


	}
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddletoBallVector;
		
			// esperando clicar no mouse.
			if (Input.GetMouseButtonDown (0)) {
				hasStarted = true;
				print ("mouse Clicked");
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
			}
		}
	}
}
