using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePersonagens{
	 
	[SerializeField] private string nome;
	[SerializeField] private Sprite imagem;

}

public class Personagens : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Massa!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
