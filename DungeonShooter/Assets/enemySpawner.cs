using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 2;
    private float timer = 0;
    public float enemyCount=6;
    public Vector2 randomX;
    public Vector2 randomY;
    private logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic=GameObject.FindWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnRate && enemyCount>0)
        {
            Instantiate(enemy,transform.position+new Vector3(Random.Range(randomX.x,randomX.y),Random.Range(randomY.x,randomY.y),0),transform.rotation);
            timer = 0;
            enemyCount-=1;
            // logic.roomEnemy+=1;
            enemy.GetComponent<enemyMovement>().enemyRoom=logic.playerRoom;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
