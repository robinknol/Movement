using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Health Health = new Health();
    void Update()
    {
        if (Health.EnemyLife <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Health.EnemyLife -= 10;
            Destroy(collision.gameObject);
        }
    }
}
