using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	
	void Awake(){
		Debug.Log("Music player awake "+ GetInstanceID());
	}
	// Use this for initialization
	void Start () {
		Debug.Log("Music player start "+ GetInstanceID());
		if( instance != null){
			Destroy(gameObject);
			print("MP deleted");
		} else{
			instance = this;
		}
		GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
