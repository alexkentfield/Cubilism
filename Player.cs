using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private float p_Speed = 20;
	private bool p_Once;
	public static int Lives = 3;
	public static int Score;
	private int scoreUp = 100;
	public static float timer = 30.0f;
	private bool movement;
	public GUIStyle text;
	// Use this for initialization
	void Start () {
		
		text.font = (Font)Resources.Load("BAUS");
		text.fontSize = 120;
		timer = 30;
	}
	
	// Update is called once per frame
	void Update () {
		
		Movement();
		if (!movement)
			timer -= Time.deltaTime;
		
	}
	
	private void Movement()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += transform.forward * Time.deltaTime * p_Speed;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position -= transform.forward * Time.deltaTime * p_Speed;
		}
		
		if (Input.GetKeyDown(KeyCode.Space) && !p_Once)
		{
			transform.rigidbody.AddForce(1500,0,0);
			p_Speed = 8;
			p_Once = true;
			movement = true;
		}
	}
	void OnGUI()
	{
		CheckLives();
		CheckTime();
		CheckScore();
	}
	private void CheckLives()
	{
		GUI.Label(new Rect(25,25,100,125),Lives.ToString(),text);
		if (Lives <= 0)
		{
			Application.LoadLevel("GameOver");
		}
	}
	private void CheckTime()
	{
		GUI.Label(new Rect(950,25,250,125),timer.ToString("F1"),text);
		if (timer <= 0)
		{
			Application.LoadLevel("Level_" + LevelSelect.levelNumber.ToString());
		}
	}
	private void CheckScore()
	{
		GUI.Label(new Rect(500,25,1000,125),Score.ToString(),text);
	}

}

