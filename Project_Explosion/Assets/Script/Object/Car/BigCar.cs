using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCar : MonoBehaviour
{
    public GameObject Win;
    public GameObject Tip_1;
    public GameObject Tip_2;
    public GameObject explosionEffect;
    public GameObject CrossHair;
    public float radius = 50f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plane")
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Collider[] collidersToDestroy = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider nearbyObject in collidersToDestroy)
            {
                Destruction dest = nearbyObject.GetComponent<Destruction>();
                if (dest != null)
                {
                    dest.Destroy();
                }
            }
            Win.SetActive(true);
            Tip_1.SetActive(false);
            Tip_2.SetActive(false);
            CrossHair.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Destroy(gameObject);
        }
    }
}
