using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citizen : MonoBehaviour
{
    public GameObject Lose;
    public GameObject citizenCorpse;
    public GameObject CrossHair;
    public GameObject Hand;
    AudioSource audioSource;

    public void citizenDead()
    {
        Lose.SetActive(true);
        Hand.SetActive(false);
        Instantiate(citizenCorpse, transform.position, transform.rotation);
        CrossHair.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;   
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2)
            audioSource.Play();
    }
}
