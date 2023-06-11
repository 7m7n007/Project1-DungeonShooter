using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    public GameObject camer;
    public Vector3 cameraPos;
    private int currentRoom;
    public int enteringRoom;
    public GameObject logic;

    // Start is called before the first frame update
    void Start()
    {
        camer=GameObject.FindWithTag("MainCamera");
        logic=GameObject.FindWithTag("Logic");
    }

    // Update is called once per frame
    void Update()
    {
        currentRoom=logic.GetComponent<logicScript>().playerRoom;
        
    }
    private void OnTriggerEnter(Collider player) {
        if(player.gameObject.tag=="Player" && enteringRoom!=currentRoom){
            camer.transform.position=cameraPos;
            logic.GetComponent<logicScript>().playerRoom=enteringRoom;
        }
    }
}
