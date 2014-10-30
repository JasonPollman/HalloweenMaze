using UnityEngine;
using System.Collections;

public class WinTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<UILabel>().text = GameObject.Find ("Timer").GetComponent<Timer> ().getTimeFormatted ();
	}
}
