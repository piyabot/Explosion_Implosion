using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject Lose;

    public void Death()
    {
        Lose.SetActive(true);
    }
}
