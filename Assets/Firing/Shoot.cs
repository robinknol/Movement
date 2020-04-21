using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        //if (collision.gameObject.tag == "Enemy")
        //{
        //    Destroy(this.gameObject);
        //    Destroy(collision.gameObject);
        //}
    }
}
