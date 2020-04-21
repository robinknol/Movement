using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    protected int MainEnemy = 10;
    public int EnemyLife
    {
        get { return MainEnemy; }
        set { MainEnemy = value; }
    }

    protected int PlayerHealth = 100;
    public int PlayerLife
    {
        get { return PlayerHealth; }
        set { PlayerHealth = value; }
    }
}