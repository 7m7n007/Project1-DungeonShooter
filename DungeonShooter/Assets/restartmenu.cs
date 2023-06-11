using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartmenu : MonoBehaviour
{
    public void restartgame2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
<<<<<<< Updated upstream
    public void quitbutton(){
        Debug.Log("QUIT!");
        Application.Quit();
=======
    public void quitbutton2(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
>>>>>>> Stashed changes
    }
}
