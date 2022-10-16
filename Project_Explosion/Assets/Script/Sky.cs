using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public GameObject Win;
    public GameObject CrossHair;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "C4")
        {
            Win.SetActive(true);
            CrossHair.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
