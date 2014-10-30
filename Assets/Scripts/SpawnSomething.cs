using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnSomething : MonoBehaviour {


	// Use this for initialization
	void Start () {

		PowerUps P = GameObject.FindGameObjectWithTag ("Player").GetComponent<PowerUps> ();
		Dictionary<string, int> T = P.TypesOfPowerups;

		List<string> keys = new List<string>(T.Keys);
		int size = T.Count;
		string randomKey = keys[(int) Mathf.Round (Random.Range (0, T.Count))];

		Debug.Log (randomKey);

		GameObject obj = Resources.Load<GameObject> (randomKey).gameObject;
		Instantiate(obj, gameObject.transform.position, obj.transform.rotation);

	}
}
