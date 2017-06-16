using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looseCollider : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D trigger){
		Debug.Log ("passou");
	}

	void OnCollisionEnter2D(Collision2D collision){
	
		Debug.Log ("bateu");
	}
}
