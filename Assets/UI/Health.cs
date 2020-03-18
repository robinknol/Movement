using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    PlayerHealth PlayerHealth = new PlayerHealth();

    [SerializeField] GameObject life;
    string PlayerLifePoints;

    void Update()
    {
//        PlayerLifePoints = System.Convert.ToString(PlayerHealth.PlayerLife);
//        life.GetComponent<TextMesh>().text = PlayerLifePoints;
    }
}
