using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public GUIStyle[] MenuStyle = new GUIStyle[2];
	private int finalScore;
	public GUIStyle text;
	private float timer;
	
	void Start()
	{
		MenuStyle[0].normal.background = (Texture2D)Resources.Load("Cubilism_GameOver");
		MenuStyle[1].normal.background = (Texture2D)Resources.Load("Cubilism_Winner");
	}
	void Update()
	{
		if (timer >= 10.0f)
		{
			Application.LoadLevel("StartMenu");
		}
		else
			timer += Time.deltaTime;
		getScore();
	}
	void OnGUI()
	{
		if (Application.loadedLevelName == "GameOver")
			GUI.Label(new Rect(0,0,Screen.width,Screen.height),"",MenuStyle[0]);
		else
			GUI.Label(new Rect(0,0,Screen.width,Screen.height),"",MenuStyle[1]);
		
		
		GUI.Label(new Rect(50,400,700,300),"SCORE: ",text);
		GUI.Label(new Rect(800,400,500,300),finalScore.ToString(),text);
	}
	
	private void getScore()
	{
		if (finalScore <= Player.Score)
		{
			finalScore++;
		}
	}
}
