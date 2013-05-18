using UnityEngine;
using System.Collections;

public class VictoryCondition : MonoBehaviour {
	
	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.name == "Player" && LevelSelect.levelNumber == 20)
		{
			Application.LoadLevel("Winner");
			Player.Score += (int)Player.timer;
		}
		else if (hit.transform.name == "Player")
		{
			Application.LoadLevel("Level_Select");
			Save_Load.levelSwitch[LevelSelect.levelNumber + 1] = 0;
			LevelSelect.checkLevels();
			Player.Score += (int)Player.timer;
		}
	}
}
