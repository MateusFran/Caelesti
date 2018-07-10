using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuvemAnim : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        speed = Random.Range(4f, 7f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.localPosition = new Vector3(Mathf.PingPong(Time.time * speed * Time.fixedDeltaTime, 0.1f), transform.localPosition.y, transform.localPosition.z);
	}
}
