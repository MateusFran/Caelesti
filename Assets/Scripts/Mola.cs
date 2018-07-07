using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mola : MonoBehaviour {


    public SpringJoint2D sp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            sp.enabled = false;
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            sp.enabled = true;
        }
		
	}
}
