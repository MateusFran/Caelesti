using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tela_JOGAR : MonoBehaviour {

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void Play()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);

    }
}
