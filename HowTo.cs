using UnityEngine;
using System.Collections;

public class HowTo : MonoBehaviour {
	public GUIStyle[] MenuStyle = new GUIStyle[2];
	public GUIStyle[] Buttons = new GUIStyle[2];
	private bool nextPage;
	// Use this for initialization
	void Start () {
		
		resetHowTo();
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		
		if (!nextPage)
			First_Page();
		else
			Second_Page();
	
	}
	
	private void First_Page()
	{
		GUI.Label(new Rect(0,0,Screen.width,Screen.height),"",MenuStyle[0]);
		if (GUI.Button(new Rect(1100,550,200,200),"",Buttons[0]))
		{
			nextPage = true;
		}
		if (GUI.Button(new Rect(25,550,200,200),"",Buttons[1]))
		{
			Application.LoadLevel("StartMenu");
		}
	}
	private void Second_Page()
	{
		GUI.Label(new Rect(0,0,Screen.width,Screen.height),"",MenuStyle[1]);
		if (GUI.Button(new Rect(25,550,200,200),"",Buttons[1]))
		{
			nextPage = false;
		}
	}
	
	private void resetHowTo()
	{
		MenuStyle[0].normal.background = (Texture2D)Resources.Load("Cubilism_HowTo_1");
		MenuStyle[1].normal.background = (Texture2D)Resources.Load("Cubilism_HowTo_2");
		Buttons[0].normal.background = (Texture2D)Resources.Load("greenCube");
		Buttons[0].hover.background = (Texture2D)Resources.Load("greenCubeHover");
		Buttons[0].active.background = (Texture2D)Resources.Load("greenCubeSelected");
		Buttons[1].normal.background = (Texture2D)Resources.Load("redCube");
		Buttons[1].hover.background = (Texture2D)Resources.Load("redCubeHover");
		Buttons[1].active.background = (Texture2D)Resources.Load("redCubeSelected");
	}
	
}
