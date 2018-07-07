using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour {
    
    [SerializeField] private Text txt;
    private int score = 0;
    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    void Start()
    {
        score = 0;
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        score++; 
    }

     void Update()
    {
        
    }
}



	
		

