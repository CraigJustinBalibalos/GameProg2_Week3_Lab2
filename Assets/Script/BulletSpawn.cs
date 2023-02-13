using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    // public static BulletSpawn Instance { get; private set; }
    public GameObject objectToSpawn;
    public GameObject bullet;
    public float timer; 
    public BulletComponent bulletComp;
    // private void Awake()
    // {
    //     Instance = this;
    // }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButton("Fire1")){
            timer += Time.deltaTime; 
        }

        if (Input.GetButtonUp("Fire1")){

        bullet = Instantiate(objectToSpawn, transform.position, transform.rotation);
        bulletComp = bullet.GetComponent<BulletComponent>(); 

        if (bullet != null)
        {
            bulletComp.force = timer*30;
            timer = 0;
        }

        }
    }
    
}
