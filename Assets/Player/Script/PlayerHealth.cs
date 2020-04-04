using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int PlayerLife = 100;
    [SerializeField] GameObject life;
    void Update()
    {
        life.GetComponent<TextMesh>().text = System.Convert.ToString(PlayerLife);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            PlayerLife -= 10;
        }
    }

    public int test()
    {
        return PlayerLife;
    }
}
