using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour {
    
    void OnMouseDown()
    {
        Destroy(this.gameObject);
        GameManager.Game.bunito.score++;
    }

    
}



	
		

