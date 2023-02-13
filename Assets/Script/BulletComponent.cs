using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public float force;
    // private void Awake()
    // {
    //     Instance = this;
    // }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        Destroy (gameObject, 5);
    }
}
