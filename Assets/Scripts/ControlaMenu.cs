using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StopAllCoroutines();
        
    }

    public void PlayGame() {
        SceneManager.LoadScene("Game");
    }
    public void CloseApp(){
        Application.Quit();
    }
}
