using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartmenu : MonoBehaviour
{
    public void restartgame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    public void quitbutton(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
