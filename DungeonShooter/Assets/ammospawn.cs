using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammospawn : MonoBehaviour
{
    
    public bulletSpawn gun;
    private GameObject player;
    public int ammocount=4;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player");
        gun=GameObject.FindWithTag("Gun").GetComponent<bulletSpawn>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider obj) {
        if (obj.gameObject.tag=="Player"){  
            gun.ammocapacity+=ammocount;
            Destroy(this);
            Destroy(GetComponent<SpriteRenderer>());
        }
    }
}
