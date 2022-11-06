using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject blood;

    private void Awake()
    {
        Instantiate(blood, transform.position, transform.rotation);
    }
}
