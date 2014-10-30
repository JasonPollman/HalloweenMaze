using UnityEngine;
using System.Collections;

public class ShowSolutions : MonoBehaviour {

	GameObject[] solutions;

	void Awake() {
		solutions = GameObject.FindGameObjectsWithTag ("Solution");
	}

	// Use this for initialization
	void Start () {
		showSolutions (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider g) {
		if(g.gameObject.tag == "Player") {
			audio.Play ();
			showSolutions(true);
			StartCoroutine(hideSolutions());
		}
	}

	void showSolutions(bool state) {
		foreach(GameObject x in solutions) {
			x.SetActive(state);
		}
	}

	IEnumerator hideSolutions() {
		yield return new WaitForSeconds (3);
		showSolutions(false);
		Destroy (gameObject);
	}
}
