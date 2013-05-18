using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {
	
	void OnTriggerEnter(Collider hit)
	{
		if (hit.transform.name == "Player")
		{
			Destroy(hit.gameObject);
			Player.Lives -= 1;
			Application.LoadLevel("Level_" + LevelSelect.levelNumber.ToString());
		}
	}
	
	
}
