using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	public Transform Target;
	public float TimeToReach;
	public Vector3 Ofset;
	private Vector3 Velocity;


	private void FixedUpdate()
	{ 

		if (this.Target != null) 
		{
			Vector3 NextPosition = Vector3.SmoothDamp (this.transform.position, this.Target.position + this.Ofset, ref this.Velocity, this.TimeToReach);
			NextPosition.z = -10;
			NextPosition.x = 0;
			this.transform.position = NextPosition;
		}
	}
}