using UnityEngine;
using System.Collections;

public class StopNKGMusic : MonoBehaviour {

	GameObject minimap;

	// Use this for initialization
	void Start () {
		minimap = GameObject.Find ("MiniMap");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider g) {
		if(g.gameObject.tag == "Player") {
			minimap.audio.Stop();
			audio.Play ();
		}
	}
}
