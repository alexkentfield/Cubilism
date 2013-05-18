using UnityEngine;
using System.Collections;

public class Save_Load : MonoBehaviour {
	public static int[] levelSwitch = new int[21];
	
	
	void Awake()
	{
		//Load_Data();
		//resetGame();
	}
	public static void resetGame()
	{
		levelSwitch[1] = 0;
		levelSwitch[2] = 1;
		levelSwitch[3] = 1;
		levelSwitch[4] = 1;
		levelSwitch[5] = 1;
		levelSwitch[6] = 1;
		levelSwitch[7] = 1;
		levelSwitch[8] = 1;
		levelSwitch[9] = 1;
		levelSwitch[10] = 1;
		levelSwitch[11] = 1;
		levelSwitch[12] = 1;
		levelSwitch[13] = 1;
		levelSwitch[14] = 1;
		levelSwitch[15] = 1;
		levelSwitch[16] = 1;
		levelSwitch[17] = 1;
		levelSwitch[18] = 1;
		levelSwitch[19] = 1;
		levelSwitch[20] = 1;
	}

	void OnApplicationQuit()
	{
		Save_Data();
	}

	protected virtual void Save_Data()
	{
		for (int i = 1; i < 21; i++)
		{
			PlayerPrefs.SetInt("Levels",levelSwitch[i]);
			Debug.Log("Saved");
		}
	}

	protected virtual void Load_Data()
	{
		for (int i = 1; i < 21; i++)
		{
			levelSwitch[i] = PlayerPrefs.GetInt("Levels");
			Debug.Log("Loaded");
			LevelSelect.checkLevels();
		}
		
	}

}