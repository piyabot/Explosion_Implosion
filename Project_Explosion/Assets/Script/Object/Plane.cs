using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject explosionEffect;
    public GameObject building;
    public UnityEngine.AI.NavMeshAgent AI;
    public CapsuleCollider collision;
    public GameObject Lose;

    void Start()
    {
        building = GameObject.FindWithTag("building");
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "building")
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Lose.SetActive(true);
            { Time.timeScale = 0; }
        }
    }
}
