using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUps : MonoBehaviour {

	public Dictionary<string, int> TypesOfPowerups = new Dictionary<string, int> () {
		{ "LookoutCandy", 5 },
		{ "BreakWallCandy", 5 },
		{ "SolutionsCandy", 5 },
		{ "Pumpkin", 50 }
	};

}
