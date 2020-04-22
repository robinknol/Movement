using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    void Update()
    {
        if (LifePoints <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            LifePoints -= 10;
            Destroy(collision.gameObject);
        }
    }
}
