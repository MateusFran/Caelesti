using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerIntroducao : MonoBehaviour {

	public Datilografia datilografia;

	// Use this for initialization
	void Start () {
		datilografia.Digitando("Introducao.txt");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
