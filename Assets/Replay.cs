﻿using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Return)) {
			Points.playerPoints = 0;
			Application.LoadLevel (1);
		}
	}

	void OnClick () {

	}
}