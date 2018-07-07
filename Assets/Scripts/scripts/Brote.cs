using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brote : MonoBehaviour {


	public GameObject target;
	public float distance;
	public int altura = -2;

	// Use this for initialization
	void Start () {

		InvokeRepeating("SpawnObject", 2, 2.0f);


	}

	void SpawnObject()
	{
		float x = Random.Range(1.0f, 11.0f);

		Instantiate(target, new Vector3(x, altura, 0), Quaternion.identity);
	
		altura += 2;
	}


}
