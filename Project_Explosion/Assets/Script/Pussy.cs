using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pussy : MonoBehaviour
{
    public GameObject Baby;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dick")
        {
            Instantiate(Baby, transform.position, transform.rotation);
        }
    }
}
