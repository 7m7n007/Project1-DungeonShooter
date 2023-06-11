using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletUI : MonoBehaviour
{
    public GameObject bulletSpawner;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text=bulletSpawner.GetComponent<bulletSpawn>().currentammo.ToString()+"/"+bulletSpawner.GetComponent<bulletSpawn>().ammocapacity;
    }
}
