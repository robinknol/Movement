using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   // public int PlayerLife = 100;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("The big sad");
    }
}
