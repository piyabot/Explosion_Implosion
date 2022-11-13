using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMine : MonoBehaviour
{
    public GameObject explosionEffect;
    public float radius = 5f;
    public float explosionForce = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LandMine_Explode();
        }
        if (other.gameObject.tag == "Object")
        {
            LandMine_Explode();
        }
    }

    public void LandMine_Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider[] collidersToDestroy = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in collidersToDestroy)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, radius);
            }

            Destruction dest = nearbyObject.GetComponent<Destruction>();
            if (dest != null)
            {
                dest.Destroy();
            }

            Citizen citz = nearbyObject.GetComponent<Citizen>();
            if (citz != null)
            {
                citz.citizenDead();
            }

            Dead lose = nearbyObject.GetComponent<Dead>();
            if (lose != null)
            {
                lose.Death();
            }
        }

        Collider[] collidersToMove = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in collidersToMove)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, radius);
            }

        }

        Destroy(gameObject);
    }
}
