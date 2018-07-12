using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BasePersonagens{
	public string nome;
	public Sprite imagem;
	public Sprite quadrado;
}

public class Personagens : MonoBehaviour {

	[SerializeField] BasePersonagens caelesti = new BasePersonagens();
	[SerializeField] BasePersonagens bruxa = new BasePersonagens();
	[SerializeField] BasePersonagens cego = new BasePersonagens();
	[SerializeField] BasePersonagens debonia = new BasePersonagens();

	[SerializeField] private Datilografia datilografia;
	[SerializeField]private Image imagemDireita;
	[SerializeField] private Sprite imagemVazia;
	[SerializeField] private Image quadradoTexto;
	[SerializeField] private Sprite padrão;

	void Update() {
		MudarPersonagem();	
	}
 void MudarPersonagem(){
	   	if (datilografia.nome == "Caelesti"){
            imagemDireita.sprite = caelesti.imagem;
			quadradoTexto.sprite = caelesti.quadrado;
        }
        else if(datilografia.nome == "XXX" || datilografia.nome == "Bruxa"){
            imagemDireita.sprite = bruxa.imagem;
			quadradoTexto.sprite = bruxa.quadrado;
        }
        else if(datilografia.nome == "???"){
            imagemDireita.sprite = cego.imagem;
			quadradoTexto.sprite = cego.quadrado;
        }
        else if(datilografia.nome == "Moça"){
			 imagemDireita.sprite = debonia.imagem;
			 quadradoTexto.sprite = debonia.quadrado;
        }
		else{
			imagemDireita.sprite = imagemVazia;
			quadradoTexto.sprite = padrão;
		}
    }
 }

