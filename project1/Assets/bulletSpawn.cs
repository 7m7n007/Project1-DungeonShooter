using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class bulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    private Vector3 mousePos;
    private Vector3 mouseOnScreen;
    private float rotation;
    public int maxammo=10;
    public int currentammo;
    private int ammoreq;

    public int ammocapacity=50; 

    public int reloadtime=3;
    private bool isreloading=false;
    // Start is called before the first frame update
    void Start()
    {
        currentammo=maxammo;
    }

    // Update is called once per frame
    void Update()
    {
        if(isreloading){
            return;
        }
    
        
        if(currentammo<=0 || Input.GetKeyDown(KeyCode.R)){
            StartCoroutine(Reload());
            return;
        }
        
      
        if (Input.GetMouseButtonDown(0)&&currentammo+ammocapacity>=0){
            currentammo--;

            //Get Mouse Position
            mousePos=Input.mousePosition;

            //Change Mouse Position to Fit According to World
            mouseOnScreen = Camera.main.ScreenToWorldPoint(mousePos);

            //Calculate the angle to be rotated 
            //Mathf.Atan2 gives the angle of a vector(y/x)/line in radian
            //We use Mathf.Rad2Deg to convert it into Degree
            //We add 180 to change range from (-180,180) to (0,360
            rotation = Mathf.Atan2((transform.position.y - mouseOnScreen.y), (transform.position.x - mouseOnScreen.x)) * Mathf.Rad2Deg + 180;
            
            //Spawning bullet and rotating to aim at the mouse Position
            Instantiate(bullet, transform.position, Quaternion.Euler(0,0,rotation));
        }
    }
    IEnumerator Reload(){
        isreloading=true;

        yield return new WaitForSeconds(reloadtime);
        Debug.Log("reloading...");
        //calu the amount of bullets needed
        ammoreq = maxammo - currentammo;
        //if it is greater than capacity then we switches it
        if (ammoreq > ammocapacity)
        {
            ammoreq = ammocapacity;
        }
        //then we increases it accordingly
        currentammo =currentammo+ammoreq;
       
        ammocapacity-=ammoreq;
        isreloading=false;
        
    }
    
}
