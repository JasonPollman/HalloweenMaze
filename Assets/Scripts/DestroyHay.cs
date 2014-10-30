using UnityEngine;
using System.Collections;

public class DestroyHay : MonoBehaviour {

	public int numberOfBalesToDestroy = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider g) {

		if(g.gameObject.tag == "Player") {

			audio.Play ();
			GameObject[] hayBales = GameObject.FindGameObjectsWithTag ("Hay");

			for(int i = 0; i < numberOfBalesToDestroy; i++) { 
				Destroy (hayBales[(int)Random.Range(0, hayBales.Length - 1)]);
			}

			StartCoroutine(Kill());
		}
	}

	IEnumerator Kill() {
		yield return new WaitForSeconds(.01f);
		Destroy (gameObject);
	}
}
