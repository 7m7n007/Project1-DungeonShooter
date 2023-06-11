using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    
    private GameObject Player;
    public float enemySpeed=0.05f;
    public float enemyHealth = 10;
    public float enemyDamage = 10;
                                  
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
        transform.position=(transform.position+(Player.transform.position-transform.position).normalized*Time.fixedDeltaTime*enemySpeed);
    }
     private void OnTriggerEnter(Collider collObj) 
    {
        if (collObj.gameObject.tag == "bullet")
        {
            enemyHealth -= collObj.GetComponent<bulletMovement>().bulletDamage; // reduce health by 10 when hit by weapon
            Destroy(collObj.gameObject);
            if (enemyHealth <= 0)
            {
                Destroy(gameObject); // destroy enemy if health is zero or less
            }
        }
    }
}
