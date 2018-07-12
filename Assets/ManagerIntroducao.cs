using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerIntroducao : MonoBehaviour {

	public static int vez;
	public Datilografia datilografia;

	void Start () {
		if(vez == 1){
			datilografia.Digitando("Introducao.txt");
			ManagerIntroducao.vez++;
		}
		else if(vez == 2){
			datilografia.Digitando("DescricaoDaLoja.txt");
			ManagerIntroducao.vez++;
		}
		else if(vez == 3){
			datilografia.Digitando("FalaComCego1");
			ManagerIntroducao.vez++;
		}
		else if (vez == 4)
		{
			
		}
	}
	
	// Update is called once per frame
}
