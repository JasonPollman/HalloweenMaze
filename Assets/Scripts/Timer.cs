using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public static float timeElapsed; 
	private int seconds, minutes, hours;

	public static bool elapseTime = true;

	// Use this for initialization
	void Start () {
		timeElapsed = seconds = minutes = hours = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if(elapseTime) timeElapsed += Time.deltaTime;


		gameObject.transform.FindChild ("Text").GetComponent<UILabel> ().text = "Time: " + getTimeFormatted();
		gameObject.transform.FindChild ("Shadow").GetComponent<UILabel> ().text = "Time: " + getTimeFormatted();
	}

	public string getTimeFormatted() {

		hours = (int) Mathf.Floor(timeElapsed / 3600);
		int minutes = (int) Mathf.Floor(timeElapsed / 60);
		int seconds = (int) Mathf.Floor(timeElapsed - (hours * 3600) - (minutes * 60));
		
		string timeFormatted = ((hours < 10) ? "0" + hours.ToString() : hours.ToString())
			+ ":" + ((minutes < 10) ? "0" + minutes.ToString() : minutes.ToString())
				+ ":" + ((seconds < 10) ? "0" + seconds.ToString() : seconds.ToString());

		return timeFormatted;
	}
}
