using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuvem : MonoBehaviour {

    private Animator animacao;

	// Update is called once per frame
	void Start () {
        animacao = GetComponentInChildren<Animator>();
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "player" && coll.gameObject.transform.position.y > transform.position.y)
        {
            animacao.SetTrigger("Aperto");
        }
    }
}
