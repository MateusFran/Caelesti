using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    private float timeLeft = 30.0f;
    public Bunito bunito;
    public Destroyer destroyer;
    public int quantidadeColidido = 0;

    [SerializeField]private Text texto;
    public float TimeLeft
    {
        get
        {
            return timeLeft;
        }
        set
        {
            timeLeft = value;
        }
    }


    void Update () {


        texto.text = "Tempo: " + Mathf.CeilToInt(timeLeft).ToString();

        timeLeft -= Time.deltaTime;
        if (bunito.QuantidadeColidido != 0)
        {
            GameOver();
        }

        if (timeLeft <= 0 && bunito.QuantidadeColidido == 0)
        {   
            
            Seila();
        }
       
	}

    void GameOver()
    {
            Invoke("mudarCena", 0.5f);
    
    }
    void mudarCena()
    {
        SceneManager.LoadScene("derrota2");
    }
    void mudarCena2()
    {
        SceneManager.LoadScene("Vitória2");
    }
    void Seila()
    {
          Invoke("mudarCena2", 0.5f);
    }
}
