using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {

	public Transform target;
	public float TimeToReach;
	public Vector3 Ofset;
	private Vector3 Velocity;
	public float ySpeed;


	private void FixedUpdate()
	{ 

		if (this.target != null && target.position.y > transform.position.y) 
		{
			Vector3 NextPosition = Vector3.SmoothDamp (this.transform.position, this.target.position + this.Ofset, ref this.Velocity, this.TimeToReach);
			NextPosition.z = -10;
			NextPosition.x = 0;
			this.transform.position = NextPosition;
		} 
		
		else 
		{
			
			transform.position += Vector3.up * ySpeed * Time.fixedDeltaTime;
		}
	}
}