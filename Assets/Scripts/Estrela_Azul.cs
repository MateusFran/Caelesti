using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Estrela_Azul : MonoBehaviour {

	[SerializeField] private string nomeCena;
	void Start() {
				
	}
	void OnTriggerEnter2D(Collider2D other) {
		
		SceneManager.LoadScene(nomeCena);
	}


}
