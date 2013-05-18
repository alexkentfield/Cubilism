using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {
	public GUIStyle[] MenuStyle = new GUIStyle[2];
	public GUIStyle[] Buttons = new GUIStyle[3];
	public GUIStyle text;
	// Use this for initialization
	void Start () {
		
		ResetMenu();
	}
	
	void OnGUI () {
		
		GUI.Label(new Rect(0,0,Screen.width,Screen.height),"",MenuStyle[0]); // Main menu screen
		GUI.Label(new Rect(0,0,Screen.width,Screen.height),"",MenuStyle[1]);
		GUI.Label(new Rect(0,675,1000,120),"Created By: Richard Grable, Alex Kentfield and William Zuniga",text);
		Check_Buttons();
	}
	
	protected void Check_Buttons()
	{
		
		if (GUI.Button(new Rect(100,150,500,500),"",Buttons[0])) // play button
		{
			Application.LoadLevel("Level_Select");
			Player.Lives = 3;
			Player.Score = 0;
			Save_Load.resetGame();
		}
		if (GUI.Button(new Rect(675,150,500,500),"",Buttons[1])) // quit button
		{
			Application.Quit();
		}
		if (GUI.Button(new Rect(490,400,300,300),"",Buttons[2])) // option button
		{
			Application.LoadLevel("HowTo");
		}
	}
	
	private void ResetMenu()
	{
		// sets the textures for the buttons and such
		LevelSelect.start = false;
		MenuStyle[0].normal.background = (Texture2D)Resources.Load("Cubilism_BackGround");
		MenuStyle[1].normal.background = (Texture2D)Resources.Load("Cubilism_Title");
		Buttons[0].normal.background = (Texture2D)Resources.Load("greenCube");
		Buttons[0].hover.background = (Texture2D)Resources.Load("greenCubeHover");
		Buttons[0].active.background = (Texture2D)Resources.Load("greenCubeSelected");
		Buttons[1].normal.background = (Texture2D)Resources.Load("redCube");
		Buttons[1].hover.background = (Texture2D)Resources.Load("redCubeHover");
		Buttons[1].active.background = (Texture2D)Resources.Load("redCubeSelected");
		Buttons[2].normal.background = (Texture2D)Resources.Load("yellowCube");
		Buttons[2].hover.background = (Texture2D)Resources.Load("yellowCubeHover");
		Buttons[2].active.background = (Texture2D)Resources.Load("yellowCubeSelected");
	}
}
