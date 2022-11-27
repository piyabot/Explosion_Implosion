using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject explosionEffect;
    public float radius = 5f;
    public GameObject building;
    public UnityEngine.AI.NavMeshAgent AI;
    public GameObject Lose;

    void Start()
    {
        
    }

    private void Update()
    {
        AI.SetDestination(building.transform.position);
        if (AI.remainingDistance < AI.stoppingDistance)
        {
            AI.speed = 0;
        }
        AI.SetDestination(building.transform.position);
        if (AI.remainingDistance > AI.stoppingDistance)
        {
            AI.speed = 30;
        }
        AI.updateRotation = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Building")
        {
            Plane_Explode();
        }
    }

    public void Plane_Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Lose.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Destroy(gameObject);
        Collider[] collidersToDestroy = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in collidersToDestroy)
        {
            Hard_Explosion explode = nearbyObject.GetComponent<Hard_Explosion>();
            if (explode != null)
            {
                explode.Hard_Explode();
            }
        }
    }
}
