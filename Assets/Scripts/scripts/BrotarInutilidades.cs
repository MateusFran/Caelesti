using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrotarInutilidades : MonoBehaviour {


	public GameObject target;
	public float distance;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnObject", 0.0f);
		InvokeRepeating("SpawnObject", 2, 1.5f);

	}
	
	void SpawnObject()
	{
		float x = Random.Range(11.0f, 16.0f);
		float y = Random.Range(-2.0f, 2.0f);
		Instantiate(target, new Vector3(x, y, 0), Quaternion.identity);
	}
}
