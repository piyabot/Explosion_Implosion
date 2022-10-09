using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    public GameObject sleep;

    public void Knock()
    {
        Instantiate(sleep, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
