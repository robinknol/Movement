using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    PlayerHealth PlayerHealth = new PlayerHealth();
    [SerializeField] GameObject life;

    void Update()
    {
       
        life.GetComponent<TextMesh>().text = System.Convert.ToString(PlayerHealth.PlayerLife);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            PlayerHealth.PlayerLife -= 10;
        }
    }
}
