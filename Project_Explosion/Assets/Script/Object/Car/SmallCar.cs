using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCar : MonoBehaviour
{
    public GameObject TryBig;
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plane")
        {
            TryBig.SetActive(true);
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
