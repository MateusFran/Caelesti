using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brotamento : MonoBehaviour {

    
    public GameObject target;
    public float distance;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnObject", 2, 1.5f);
	}
	
    void SpawnObject()
    {
        float x = Random.Range(3.0f,6.0f);
        float y = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, y, 0), Quaternion.identity);
    }

}
