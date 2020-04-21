using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionShot : MonoBehaviour
{
    public bool isFiring;

    public Shoot Shoot;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    
    void Update()
    {
        //Debug.Log("ShotCounter in Update = " + shotCounter);
        //shotCounter = timeBetweenShots;
        if (isFiring == true)
        {
            shotCounter -= Time.deltaTime;
            Debug.Log("ShotCounter after -= Time.deltaTime = " + shotCounter);
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                Shoot newbullet = Instantiate(Shoot, firePoint.position, firePoint.rotation) as Shoot;
                newbullet.speed = bulletSpeed;
                //Debug.Log("ShotCounter after bullet is spawned = " + shotCounter);
            }
            //else
            //{
            //    shotCounter = 0;
                //Debug.Log("ShotCounter after else = " + shotCounter);
            //}
        }
    }
}
