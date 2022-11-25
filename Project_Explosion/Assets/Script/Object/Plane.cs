using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject explosionEffect;
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
            AI.speed = 10;
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
        Destroy(gameObject);
    }
}
