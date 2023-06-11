using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerRoom = 0;
    public bool room0Completed = false;
    public bool room1Completed = false;
    public bool room2Completed = false;
    public bool room3Completed = false;
    
    public List<int> roomEnemy;
    public List<GameObject> room0Spawners;
    public List<GameObject> room1Spawners;
    public List<GameObject> room2Spawners;
    public List<GameObject> room3Spawners;
    public GameObject gate1;
    public GameObject gate2;
    public GameObject gate3;
    public GameObject gate1b;
    public GameObject gate2b;
    public GameObject gate3b;

    public GameObject ammo0;
    public GameObject ammo1;
    public GameObject ammo2;
    public GameObject ammo3;
    public int enemyReq=6;

    // Start is called before the first frame update
    void Start()
    {
        roomEnemy.Add(enemyReq);
        roomEnemy.Add(enemyReq);
        roomEnemy.Add(enemyReq);
        roomEnemy.Add(enemyReq);
        room0Spawners = GameObject.FindGameObjectsWithTag("Room0").ToList();
        room1Spawners = GameObject.FindGameObjectsWithTag("Room1").ToList();
        room2Spawners = GameObject.FindGameObjectsWithTag("Room2").ToList();
        room3Spawners = GameObject.FindGameObjectsWithTag("Room3").ToList();
        Debug.Log(room0Spawners.Count);
        for (int i = 0; i < room0Spawners.Count; i++)
        {
            room0Spawners[i].SetActive(false);
        }
        for (int i = 0; i < room1Spawners.Count; i++)
        {
            room1Spawners[i].SetActive(false);
        }
        for (int i = 0; i < room2Spawners.Count; i++)
        {
            room2Spawners[i].SetActive(false);
        }
        for (int i = 0; i < room3Spawners.Count; i++)
        {
            room3Spawners[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(room0Completed &&room1Completed&&room2Completed&&room3Completed){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
        }
        // Debug.Log(room1Spawners[0].transform.position);
        if(!room0Completed){
            enableRoomSpawner(0);
        }
        if (room0Completed)
        {
            disableRoomSpawner(0);
            gate1.SetActive(false);
            ammo0.SetActive(true);
        }
        if (room1Completed)
        {
            disableRoomSpawner(1);
            gate1b.SetActive(false);
            gate2.SetActive(false);
            ammo1.SetActive(true);
        }
        if (room2Completed)
        {
            disableRoomSpawner(2);
            gate2b.SetActive(false);
            gate3.SetActive(false);
            ammo2.SetActive(true);
        }
        if (room3Completed)
        {
            disableRoomSpawner(3);
            gate3b.SetActive(false);
            ammo3.SetActive(true);
        }
        if (roomEnemy[0] <= 0)
        {
            room0Completed = true;
        }
        if (roomEnemy[1] <= 0)
        {
            room1Completed = true;
        }
        if (roomEnemy[2] <= 0)
        {
            room2Completed = true;
        }
        if (roomEnemy[3] <= 0)
        {
            room3Completed = true;
        }
    }
    public void disableRoomSpawner(int rooms)
    {
        if (rooms == 0)
        {
            for (int i = 0; i < room0Spawners.Count; i++)
            {
                room0Spawners[i].SetActive(false);
            }
        }
        if (rooms == 1)
        {
            for (int i = 0; i < room1Spawners.Count; i++)
            {
                room1Spawners[i].SetActive(false);
            }
        }
        if (rooms == 2)
        {
            for (int i = 0; i < room2Spawners.Count; i++)
            {
                room2Spawners[i].SetActive(false);
            }
        }
        if (rooms == 3)
        {
            for (int i = 0; i < room3Spawners.Count; i++)
            {
                room3Spawners[i].SetActive(false);
            }
        }
        

    }
    public void enableRoomSpawner(int rooms)
    {
        if (rooms == 0)
        {
            for (int i = 0; i < room0Spawners.Count; i++)
            {
                room0Spawners[i].SetActive(true);
            }
        }
        if (rooms == 1)
        {
            for (int i = 0; i < room1Spawners.Count; i++)
            {
                room1Spawners[i].SetActive(true);
            }
        }
        if (rooms == 2)
        {
            for (int i = 0; i < room2Spawners.Count; i++)
            {
                room2Spawners[i].SetActive(true);
            }
        }
        if (rooms == 3)
        {
            for (int i = 0; i < room3Spawners.Count; i++)
            {
                room3Spawners[i].SetActive(true);
            }
        }
        

    }
}
