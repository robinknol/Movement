using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    PlayerHealth PlayerHealth = new PlayerHealth();
    //PlayerHealth sc = ScriptableObject.
    //public static ScriptableObject 


    [SerializeField] GameObject life;

    void Update()
    {
        Debug.Log(PlayerHealth.test());
        life.GetComponent<TextMesh>().text = System.Convert.ToString(PlayerHealth.PlayerLife);
    }
}
