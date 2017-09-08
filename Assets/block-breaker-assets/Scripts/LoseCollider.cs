using System.Collections;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void Start() {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D trigger){
		print("Trigger");
	}

	void OnCollisionEnter2D(Collision2D collision){
		print("Collision");
		levelManager.LoadLevel("Lose Screen");
	}
}
