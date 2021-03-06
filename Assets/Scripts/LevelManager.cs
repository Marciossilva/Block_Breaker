﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string level){
		Brick.breakableCount = 0;
		SceneManager.LoadScene(level);
	}

	public  void QuitRequest(){
		Application.Quit ();
	}

	public void LoadNextLevel (){
		Application.LoadLevel(Application.loadedLevel+1);
	}

	public void BrickDestroyed(){
		if (Brick.breakableCount <= 0) {
			LoadNextLevel ();
		}
	}
}
