using UnityEngine;
using System.Collections;

public class RemovePumpkin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider g) {

		if(g.gameObject.tag == "Player") {

			audio.Play();

			StartCoroutine(KillPumpkin());
		}
	}

	IEnumerator KillPumpkin() {
		yield return new WaitForSeconds(.01f);
		Destroy (gameObject);
	}
}
