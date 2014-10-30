using UnityEngine;
using System.Collections;

public class MiniMapArrow : MonoBehaviour {

	public float offset = 110;

	// Use this for initialization
	void Start () {

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		gameObject.transform.position = new Vector3 (player.transform.position.x, 50, player.transform.position.z);
		gameObject.transform.rotation = Quaternion.Euler (90f, player.transform.eulerAngles.y - offset, 0);

	}

	// Update is called once per frame
	void Update () { Start (); }
}
