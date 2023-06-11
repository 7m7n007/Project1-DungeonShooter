using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winscreen : MonoBehaviour
{
   public void restartgame1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
    public void quitbutton1(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
    }
}
