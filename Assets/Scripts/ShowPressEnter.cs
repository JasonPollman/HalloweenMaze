using UnityEngine;
using System.Collections;

public class ShowPressEnter : MonoBehaviour {

	private bool lookoutMode = false;
	private GameObject pressEnter;

	void Awake() {
		pressEnter = GameObject.Find ("PressEnter");
	}

	// Use this for initialization
	void Start () {
		if(pressEnter.activeInHierarchy) pressEnter.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(lookoutMode == true && Input.GetKey(KeyCode.Return)) {
			pressEnter.SetActive (false);
		}
	}

	void OnTriggerEnter () {

		if(lookoutMode == false) {
			pressEnter.SetActive (true);
			lookoutMode = true;
		}
	}
}
