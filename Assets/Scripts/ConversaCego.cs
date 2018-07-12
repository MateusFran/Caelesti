using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversaCego : MonoBehaviour {

    public Datilografia datilografia;

	// Use this for initialization
	void Start () {
        DigitarDialogo("FalaComCego1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void DigitarDialogo(string nomeArquivo)
    {
        datilografia.Digitando(nomeArquivo + ".txt");
    }
}

