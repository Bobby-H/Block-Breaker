using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D trigger){
		print("Trigger");
	}

	void OnCollisionEnter2D(Collision2D collision){
		print("Collision");
//		levelManager.LoadLevel("Win Screen");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
