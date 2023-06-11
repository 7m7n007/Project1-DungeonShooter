using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class checkAttack : MonoBehaviour
{
    private playerhealth health;
    private logicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        health=GetComponent<playerhealth>();
        logic=GameObject.FindWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag=="Enemy"){
            health.Takedamage(20);
            Destroy(other.gameObject);
            logic.roomEnemy[other.GetComponent<enemyMovement>().enemyRoom]-=1;
        }
    }
}
