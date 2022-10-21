using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 10f;
    //public GameObject _explosionEffect;
    
    void Update()
    {
        //transform.position += new Vector3(-10,0,0)*Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Instantiate(_explosionEffect, transform.position, Quaternion.identity);
            Destroy(GameObject);
        }
    }
    */
}
