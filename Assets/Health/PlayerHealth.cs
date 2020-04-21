using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    Health Health = new Health();
    [SerializeField] GameObject life;

    void Update()
    {
        if (Health.PlayerLife <= 0)
        {
            SceneManager.LoadScene("Death");
        }
        life.GetComponent<TextMesh>().text = System.Convert.ToString(Health.PlayerLife);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Health.PlayerLife -= 10;
            Destroy(collision.gameObject);
        }
    }
}
