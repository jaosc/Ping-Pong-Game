using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaParedeLateral : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D objetoDeColisao)
    {
        if(objetoDeColisao.tag == "Bola"){
            SceneManager.LoadScene("Menu");
        }
        
    }

}
