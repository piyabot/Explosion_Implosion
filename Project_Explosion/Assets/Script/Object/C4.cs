using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4 : MonoBehaviour
{
    public GameObject explosionEffect;
    public float radius = 100f;
    public float explosionForce = 1000f;

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sky")
        {
            C4_Explode();
        }
    }
    
    public void C4_Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
