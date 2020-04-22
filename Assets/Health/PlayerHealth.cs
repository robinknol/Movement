using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{
    //Health Health = new Health();
    [SerializeField] GameObject life;

    void Update()
    {
        if (LifePoints <= 0)
        {
            SceneManager.LoadScene("Death");
        }
        life.GetComponent<TextMesh>().text = System.Convert.ToString(LifePoints);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            LifePoints -= 10;
            Destroy(collision.gameObject);
        }
    }
}
