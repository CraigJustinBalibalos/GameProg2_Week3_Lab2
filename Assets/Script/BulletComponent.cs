using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public BulletSpawn bullet;
    // public GameObject bullet;
    // public float force = 50;
    public float chargeSpeed = 5;
    public float timer;
    public bool charging;
    public float power;
    // private void Awake()
    // {
    //     Instance = this;
    // }
    // Start is called before the first frame update
    void Start()
    {
        // force = BulletSpawn.Instance.force;
        // if (Input.GetButtonDown("Fire1")){
        //     GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        // }
        // float power = GameObject.Find("BulletSpawnPoint").GetComponent<BulletSpawn>().force;
        // GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.Impulse);
        // bullet = FindObjectOfType<BulletSpawn>();
        // if (Input.GetButtonDown("Fire1")){
        //     charging = true;

        // }
        // if (Input.GetButton("Fire1")){
        //     power += chargeSpeed*Time.deltaTime;
        // }
        // if (Input.GetButtonUp("Fire1")){
        //     charging = false;
        // }
        // if(charging == false){
        //     GetComponent<Rigidbody>().AddForce(transform.forward * bullet.force, ForceMode.Impulse);
        // }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            charging = true;
            power = 0;
        }
        if (Input.GetButton("Fire1")){
            power += chargeSpeed*Time.deltaTime;
        }
        if (Input.GetButtonUp("Fire1")){
            charging = false;
        }
        if(charging == false){
            GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.Impulse);
        }
        
        Destroy (gameObject, 5);
    }
}
