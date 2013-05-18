using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour { // moves the player from one spot to another
	public GameObject End; // manually connected for multiple teleports
	
	
	void OnTriggerEnter (Collider hit) {
		
		if (hit.gameObject.name == "Player")
		{
			hit.transform.position = End.transform.position;
		}
	
	}
}
