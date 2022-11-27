using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescue : MonoBehaviour
{
    public GameObject Win;
    public GameObject CrossHair;
    public GameObject Lose;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            Win.SetActive(true);
            CrossHair.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (other.gameObject.tag == "C4")
        {
            Lose.SetActive(true);
            CrossHair.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
