using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public float bulletSpeed = 5;
    public float bulletRange = 5;
    public float bulletDamage = 10;
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > bulletRange)
        {
            Destroy(gameObject);
        }
        transform.position += transform.right * Time.fixedDeltaTime * bulletSpeed;
        timer += Time.fixedDeltaTime;
    }
}
