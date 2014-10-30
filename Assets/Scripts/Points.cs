using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

	public static int playerPoints = 0;
	public int points = 50;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("Points/Text").GetComponent<UILabel> ().text   = "Points: " + playerPoints;
		GameObject.Find ("Points/Shadow").GetComponent<UILabel> ().text = "Points: " + playerPoints;
	}

	void OnTriggerEnter(Collider g) {
		if(g.gameObject.tag == "Player") {
			playerPoints += points;
		}
	}
}
