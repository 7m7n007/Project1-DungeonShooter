using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartmenu : MonoBehaviour
{
    public void restartgame2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }


 

    public void quitbutton2(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
}
