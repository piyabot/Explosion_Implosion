using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abaddon : MonoBehaviour
{
    public GameObject Lose;
    public GameObject Tip;
    public GameObject CrossHair;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Lose.SetActive(true);
            Tip.SetActive(false);
            CrossHair.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
