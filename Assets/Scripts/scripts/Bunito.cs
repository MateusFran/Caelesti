using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bunito : MonoBehaviour
{
    private int quantidadeColidido = 0;
    public int QuantidadeColidido
    {
        get
        {
            return quantidadeColidido;
        }
        set
        {
            quantidadeColidido = value;
        }
    }

    private int outroColidido = 0;
    public int OutroColidido
    {
        get
        {
            return outroColidido;
        }
        set
        {
            outroColidido = value;
        }
    }

    public Destroyer destroyer;
    [SerializeField] private Text txt;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("coisa"))
        {
            Destroy(coll.gameObject);
             quantidadeColidido++;   
            
        }

        if (coll.gameObject.CompareTag("outracoisa"))
        {
            Destroy(coll.gameObject);
           
        }

    }
}