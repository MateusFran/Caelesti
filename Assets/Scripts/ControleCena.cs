using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCena : MonoBehaviour {

	[SerializeField] private int vez;
	 public int Vez
    {
        get
        {
            return vez;
        }
        set
        {
            vez = value;
        }
    }
	//public Datilografia datilografia;
	[SerializeField] private GameObject cena1;
	[SerializeField] private GameObject cena2;

		
	// Use this for initialization
	void Start () {
		if (vez != 3){
			cena2.SetActive(false);
			cena1.SetActive(true);
			//DigitarDialogo("FalaComCego");
		}
		else if (vez == 2) {
			cena1.SetActive(false);
			cena2.SetActive(true);
			//DigitarDialogo("FalaComCego2");
		}
	}
	// // private void DigitarDialogo(string nomeArquivo)
    // {
    //     datilografia.Digitando(nomeArquivo + ".txt");
    // }
}