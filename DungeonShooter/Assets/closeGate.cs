using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class closeGate : MonoBehaviour
{
    public GameObject gate;
    private logicScript logic;
    public int trigRoom;
    // Start is called before the first frame update
    void Start()
    {
        logic=GameObject.FindWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            Debug.Log("gate locked");
            gate.gameObject.SetActive(true);
            logic.enableRoomSpawner(trigRoom);

        }
    }
}
