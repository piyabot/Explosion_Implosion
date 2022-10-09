using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour
{
    public float throwForce = 40f;
    public GameObject Lethalgrenade;
    public GameObject NonLethalgrenade;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ThrowLethal();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ThrowNonLethal();
        }
    }

    void ThrowLethal()
    {
        GameObject grenade = Instantiate(Lethalgrenade, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }

    void ThrowNonLethal()
    {
        GameObject grenade = Instantiate(NonLethalgrenade, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
}
