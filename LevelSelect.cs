using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {
	public GUIStyle MenuStyle = new GUIStyle();
	public GUIStyle[] block = new GUIStyle[2];
	public static int[] levels = new int[21];
	public static bool start = false;
	public static int levelNumber;
	// Use this for initialization
	void Start () {
		
		ResetLevelSelect();
		checkLevels();
		
	}
	void OnGUI () {
		
		GUI.depth = -4;
		GUI.Label(new Rect(0,0,Screen.width,Screen.height),"",MenuStyle);
		for (int i = 1; i < 6; i++) // Algorithm for the level select blocks
			{
				for (int j = 0; j < 4; j++)
				{
					int k = j * 5 + i;
					if (GUI.Button(new Rect(i * 185,j * 185,150,150),"",block[levels[k]]))
					{
	
						if (levels[k] == 1)
							return;
						else
						{
							Application.LoadLevel("Level_" + k.ToString());
							levelNumber = k;
							Player.Lives = 3;
						}
					}
					GUI.Label(new Rect(i * 185,j * 185,150,150), k.ToString());
				}
	
			}
			
	}
	private void ResetLevelSelect()
	{
		block[0].normal.background = (Texture2D)Resources.Load("greenCube");
		block[0].hover.background = (Texture2D)Resources.Load("greenCubeHover");
		block[0].active.background = (Texture2D)Resources.Load("greenCubeSelected");
		block[1].normal.background = (Texture2D)Resources.Load("redCube");
		block[1].hover.background = (Texture2D)Resources.Load("redCubeHover");
		block[1].active.background = (Texture2D)Resources.Load("redCubeSelected");
		
	}
	
	public static void checkLevels()
	{
		levels[1] = Save_Load.levelSwitch[1];
		levels[2] = Save_Load.levelSwitch[2];
		levels[3] = Save_Load.levelSwitch[3];
		levels[4] = Save_Load.levelSwitch[4];
		levels[5] = Save_Load.levelSwitch[5];
		levels[6] = Save_Load.levelSwitch[6];
		levels[7] = Save_Load.levelSwitch[7];
		levels[8] = Save_Load.levelSwitch[8];
		levels[9] = Save_Load.levelSwitch[9];
		levels[10] = Save_Load.levelSwitch[10];
		levels[11] = Save_Load.levelSwitch[11];
		levels[12] = Save_Load.levelSwitch[12];
		levels[13] = Save_Load.levelSwitch[13];
		levels[14] = Save_Load.levelSwitch[14];
		levels[15] = Save_Load.levelSwitch[15];
		levels[16] = Save_Load.levelSwitch[16];
		levels[17] = Save_Load.levelSwitch[17];
		levels[18] = Save_Load.levelSwitch[18];
		levels[19] = Save_Load.levelSwitch[19];
		levels[20] = Save_Load.levelSwitch[20];
		
		
	}
	
}
