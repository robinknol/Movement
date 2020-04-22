using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    //protected int MainEnemy = 10;
    //public int EnemyLife
    //{
    //    get { return MainEnemy; }
    //    set { MainEnemy = value; }
    //}

    //protected int health = 100;
    public int LifePoints
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }
}