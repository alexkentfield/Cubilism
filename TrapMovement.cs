using UnityEngine;
using System.Collections;

public class TrapMovement : MonoBehaviour {
	private float speed = 10;
	public bool move = true;
	public float timeSpeed = 1.0f;
	public bool reverse;
	public float rotSpeed;
	public bool rotate;
	private float reverseTimer;
	private bool reverseSwitch;
	
	// Update is called once per frame
	void Update () {
		if (move)
		{
			if (!reverse)
			{
				if (!reverseSwitch)
					Up_Movement();
				else
					Down_Movement();
			}
			else
			{
				if (!reverseSwitch)
					Reverse_Up();
				else
					Reverse_Down();
			}
		}
		if (rotate)
		{
			CheckRotate();
		}
	
	}
	
	private void Up_Movement()
	{
		if (reverseTimer >= timeSpeed)
		{
			reverseSwitch = true;
		}
		
		transform.position += transform.forward * Time.deltaTime * speed;
		reverseTimer += Time.deltaTime;
	}
	private void Down_Movement()
	{
		if (reverseTimer <= 0.0)
		{
			reverseSwitch = false;
		}
		
		transform.position -= transform.forward * Time.deltaTime * speed;
		reverseTimer -= Time.deltaTime;
	}
	
	private void Reverse_Down()
	{
		if (reverseTimer >= 0.0)
		{
			reverseSwitch = false;
		}
		
		transform.position += transform.forward * Time.deltaTime * speed;
		reverseTimer += Time.deltaTime;
	}
	private void Reverse_Up()
	{
		if (reverseTimer <= timeSpeed)
		{
			reverseSwitch = true;
		}
		
		transform.position -= transform.forward * Time.deltaTime * speed;
		reverseTimer -= Time.deltaTime;
	}
	
	private void CheckRotate()
	{
		transform.Rotate(0.0f,rotSpeed,0.0f);
	}
	
	
}
