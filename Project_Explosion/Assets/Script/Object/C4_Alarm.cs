using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4_Alarm : MonoBehaviour
{
    public float delay = 36f;
    public GameObject explosionEffect;
    public float radius = 5f;
    public float explosionForce = 1000f;
    public GameObject Lose;

    float countdown;
    bool hasExploed = false;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploed)
        {
            Explode();
            hasExploed = true;
        }
    }

    void Explode()
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

            Hard_Explosion explode = nearbyObject.GetComponent<Hard_Explosion>();
            if (explode != null)
            {
                explode.Hard_Explode();
            }

            Citizen citz = nearbyObject.GetComponent<Citizen>();
            if (citz != null)
            {
                citz.citizenDead();
            }

            T_Lose t = nearbyObject.GetComponent<T_Lose>();
            if (t != null)
            {
                t.bomber_explode();
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
        Lose.SetActive(true);
        Destroy(gameObject);
    }
}
