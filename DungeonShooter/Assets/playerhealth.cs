using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerhealth : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;
    public healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
        healthbar.setmaxhealth(maxhealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Takedamage(int damage)
    {
        currenthealth-=damage;
        healthbar.sethealth(currenthealth);
        if(currenthealth==0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
