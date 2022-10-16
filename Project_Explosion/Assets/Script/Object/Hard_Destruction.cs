using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard_Destruction : MonoBehaviour
{
    public GameObject destroyed;

    public void HardDestroy()
    {
        Destroy(gameObject);
        Instantiate(destroyed, transform.position, transform.rotation);
    }
}
