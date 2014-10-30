using UnityEngine;
using System.Collections;

public class CandyGrow : MonoBehaviour {

	private bool lookoutMode = false;

	private Vector3 originalPos;
	private float 	originalSpeed;
	private float   originalHeight;
	private GameObject pressEnter;


	// Use this for initialization
	void Start () {
		if(pressEnter.activeInHierarchy) pressEnter.SetActive (false);
	}

	void Awake () {
		pressEnter = GameObject.Find ("PressEnter");
	}
	
	// Update is called once per frame
	void Update () {

		GameObject g = GameObject.FindGameObjectWithTag ("Player");

		if(Input.GetKey(KeyCode.Return) && lookoutMode == true) {

			g.gameObject.transform.position = originalPos;
			g.gameObject.GetComponent<CharacterController> ().height = originalHeight;
			g.gameObject.GetComponent<CharacterMotor>().movement.maxForwardSpeed = originalSpeed;
			
			lookoutMode = false;
			pressEnter.SetActive (false);

			Destroy(gameObject);
		}
		else if (lookoutMode) {
			g.transform.position = new Vector3(originalPos.x, 100/2, originalPos.z);
		}
	
	}

	void OnTriggerEnter (Collider g) {

		if(g.gameObject.tag == "Player" && lookoutMode == false) {

			audio.Play();

			pressEnter.SetActive (true);;

			originalSpeed 	= g.gameObject.GetComponent<CharacterMotor>().movement.maxForwardSpeed;
			originalPos		= g.gameObject.transform.position;
			originalHeight  = g.gameObject.GetComponent<CharacterController> ().height;

			g.gameObject.transform.position = new Vector3(g.gameObject.transform.position.x, 100/2, g.gameObject.transform.position.z);
			g.gameObject.GetComponent<CharacterController> ().height = 100;
			g.gameObject.GetComponent<CharacterMotor>().movement.maxForwardSpeed = 0;

			lookoutMode = true;
		}
	}
}
