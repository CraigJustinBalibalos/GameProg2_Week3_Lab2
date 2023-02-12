using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public static BulletSpawn Instance { get; private set; }
    public float force;
    public float chargeSpeed = 3;
    public GameObject objectToSpawn;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButton("Fire1")){
            force += chargeSpeed*Time.deltaTime;   
        }
        // if (Input.GetButtonDown("Fire1")){
        //     GetComponent<BulletComponent>().enabled = false; 
        // }
        if (Input.GetButtonUp("Fire1")){
            Debug.Log("FIRE!!!");
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            force = 0;

        }
    }
    
}
