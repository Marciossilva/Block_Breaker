﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
	public AudioClip crack;
	public static int breakableCount = 0;
	public Sprite[] hitSprites;
	public GameObject smoke;

	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;

	// Use this for initialization

	void Start ()
	{
		isBreakable = (this.tag == "Breakable");
		// keep track of breakeable bricks

		if (isBreakable) {
			breakableCount++;
		
		}

		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		AudioSource.PlayClipAtPoint (crack, transform.position);
		if (isBreakable) {
			HandleHits ();
		}
	}

	void HandleHits ()
	{
		timesHit++;
		int maxHits = hitSprites.Length + 1;

		if (timesHit >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed ();
			PuffSmoke ();
			Destroy (gameObject);

	
		} else {
			LoadSprites ();		
		}
	}

	void PuffSmoke(){
		GameObject smokePuff = Instantiate (smoke, gameObject.transform.position, Quaternion.identity)as GameObject;
		smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer> ().color;
	}

	void LoadSprites ()
	{
		int spriteIndex = timesHit - 1;

		if (hitSprites [spriteIndex] ) {
			this.GetComponent < SpriteRenderer> ().sprite = hitSprites [spriteIndex]; 
		} else {

		}
	}

	// TODO remover depois
	void SimulatedWin ()
	{
		levelManager.LoadNextLevel ();
	}
}
