﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looseCollider : MonoBehaviour {

	private LevelManager levelManager;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D trigger){
		levelManager = GameObject.FindObjectOfType<LevelManager>();

		levelManager.LoadLevel ("Lose");
	}

	void OnCollisionEnter2D(Collision2D collision){
	

	}
}
