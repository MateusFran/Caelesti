using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour {


	[SerializeField]
	private float velocidade;

	void Update () {
		Vector3 posicao = transform.position;
		posicao.y += velocidade;
		transform.position = posicao;
	}
}
