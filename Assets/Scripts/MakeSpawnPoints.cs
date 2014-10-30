using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeSpawnPoints : MonoBehaviour {

	private int numberOfSpawnPoints = 0;

	// Use this for initialization
	void Start () {

		PowerUps pu = GameObject.FindGameObjectWithTag ("Player").GetComponent<PowerUps> ();

		foreach(KeyValuePair<string, int> e in pu.TypesOfPowerups) {

			for(int i = 0; i < e.Value; i++) {
				
				GameObject obj = Resources.Load<GameObject>(e.Key);
				Vector3 randomPos = new Vector3(Random.Range(0, GameObject.Find("WallBack").gameObject.transform.position.x + 1),
				                                obj.transform.position.y,
				                                Random.Range(0, GameObject.Find("WallLeft").gameObject.transform.position.z + 1));
				
				
				var checkResult = Physics.OverlapSphere(randomPos, .2f);
				
				if (checkResult.Length == 0) {
					Instantiate(obj, randomPos, obj.transform.rotation);
				}
				else {
					Debug.Log ("collision" + obj.ToString());
					i--;
				}
				
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}