using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour {

	GameObject gameWin;

	// Use this for initialization
	void Start () {
		gameWin = GameObject.Find ("GameWin");
		gameWin.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider g) {
		if(g.gameObject.tag == "Player") {
			Points.playerPoints += (int)(600 - Timer.timeElapsed);
			gameWin.SetActive (true);
			Timer.elapseTime = false;
			GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMotor>().movement.maxForwardSpeed = 0;
		}
	}
}
