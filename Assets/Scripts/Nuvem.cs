using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuvem : MonoBehaviour {

    private Animator animacao;

	// Update is called once per frame
	void Update () {
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Nuvem")
        {
        }
    }
}
