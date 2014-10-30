using UnityEngine;
using System.Collections;

public class ShiftToRun : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftShift)) {
			gameObject.GetComponent<CharacterMotor>().movement.maxForwardSpeed = 25;
		}
		else {
			gameObject.GetComponent<CharacterMotor>().movement.maxForwardSpeed = 8;
		}
	}
}
