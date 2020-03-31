using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    PlayerHealth PlayerHealth = new PlayerHealth();

    [SerializeField] GameObject life;

    void Update()
    {
        string PlayerLifePoints = System.Convert.ToString(PlayerHealth.PlayerLife);
        life.GetComponent<TextMesh>().text = PlayerLifePoints;
    }
}
