using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public GameObject Win;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "C4")
        {
            Win.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
