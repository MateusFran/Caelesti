using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Parallax : MonoBehaviour {

	public RawImage img;
	public float speed;
	
	void Update () {
		
		Rect rect = img.uvRect; 
		rect.y += speed;
		img.uvRect = rect;
		
	}
}
