using UnityEngine;
using System.Collections;

public class Ghosts : MonoBehaviour {
	public Material ColorA;
	public Material ColorB;
	private float Timer;
	private bool reverse;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!reverse)
			Check_Visible();
		else
			Check_Invisible();
		
	
	}
	
	protected void Check_Visible()
	{
		renderer.material.color = Color.Lerp(ColorA.color,ColorB.color,Timer);
		if (Timer >= 1.0f)
		{
			reverse = true;
		}
		Timer += 0.005f;
	}
	
	protected void Check_Invisible()
	{
		renderer.material.color = Color.Lerp(ColorA.color,ColorB.color,Timer);
		if (Timer <= 0.0f)
		{
			reverse = false;
		}
		Timer -= 0.0001f;
	}
}
