using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel_Explosion : MonoBehaviour
{
    public GameObject explosionEffect;
    public float radius = 15f;
    public float explosionForce = 1500f;

    // Update is called once per frame
    void Update()
    {

    }

    public void Barrel_Explode()
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

            Hard_Destruction Dest = nearbyObject.GetComponent<Hard_Destruction>();
            if (Dest != null)
            {
                Dest.HardDestroy();
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
