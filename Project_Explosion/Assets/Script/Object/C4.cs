using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4 : MonoBehaviour
{
    public GameObject explosionEffect;
    public float radius = 5f;
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
        Collider[] collidersToDestroy = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in collidersToDestroy)
        {
            Destruction dest = nearbyObject.GetComponent<Destruction>();
            if (dest != null)
            {
                dest.Destroy();
            }

            Hard_Explosion explode = nearbyObject.GetComponent<Hard_Explosion>();
            if (explode != null)
            {
                explode.Hard_Explode();
            }
        }

        Destroy(gameObject);
    }
}
