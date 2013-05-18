using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	private bool lockedOn;
	private float MoveTimer;
	private float Cooldown;
	public float C_Time;
	public float M_Time;
	public float speed;
	public bool tracker;
	
	// Update is called once per frame
	void Update () {
		
		if (!tracker)
		{
			if (!lockedOn)
			{
				FindPlayer();
				MoveTimer = 0.0f;
			}
			else
			{
				Move();
				Cooldown = 0.0f;
			}
		}
		else
		{
		}
			
	}
	
	private void FindPlayer()
	{
		if (Cooldown >= C_Time)
		{
			lockedOn = true;
		}
		else
		{
			Cooldown += Time.deltaTime;
			transform.LookAt(GameObject.Find("Player").transform);
		}
	}
	
	private void Move()
	{
		if (MoveTimer >= M_Time)
		{
			lockedOn = false;
		}
		else
		{
			MoveTimer += Time.deltaTime;
			transform.position += transform.forward * Time.deltaTime * speed;
		}
	}
	private void Track()
	{
		transform.LookAt(GameObject.Find("Player").transform);
		transform.position += transform.forward * Time.deltaTime * speed;
	}
	void OnTriggerStay(Collider hit)
	{
		if (hit.gameObject.name == "Player" && tracker)
		{
			Track();
		}
		
	}
}
