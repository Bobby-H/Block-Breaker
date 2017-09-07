using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D trigger){
		print("Trigger");
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnCollisionEnter2D(Collision2D collision){
		print("Collision");
		levelManager.LoadLevel("Lose Screen");
	}
}
