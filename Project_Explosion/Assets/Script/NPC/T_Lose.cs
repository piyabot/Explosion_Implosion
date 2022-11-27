using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Lose : MonoBehaviour
{
    public GameObject bomber;

    public void bomber_explode()
    {
        Destroy(gameObject);
        Instantiate(bomber, transform.position, transform.rotation);
    }
}
