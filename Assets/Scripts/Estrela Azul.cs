using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EstrelaAzul : MonoBehaviour {

  

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Collectable")
        {
            Destroy(coll.gameObject);

        }
    }

    void GameOver()
    {

        Invoke("mudarCena", 0.1f);
    }

    void mudarCena()
    {
            SceneManager.LoadScene("Historia pt2");
    }
}
