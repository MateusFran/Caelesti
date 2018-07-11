using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bunito : MonoBehaviour
{
    [SerializeField] private Text txt;
    //[SerializeField] private int score = 0;

    public int score;
    
    private int quantidadeColidido = 0;
    public int QuantidadeColidido{ get; set;}

    private int outroColidido = 0;
    public int OutroColidido{ get; set;}

    

    void Update()
    {
         txt.text = "Meteoros: " + score;
         print("Update");
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("coisa"))
        {
            Destroy(coll.gameObject);
             quantidadeColidido++;   
            
        }

        else if (coll.gameObject.CompareTag("outracoisa"))
        {
            Destroy(coll.gameObject);
           
        }

    }
}