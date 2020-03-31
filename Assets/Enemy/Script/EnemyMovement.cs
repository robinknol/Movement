using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] Vector3 PlayerLocation;
    [SerializeField] NavMeshAgent Enemy;
    void Start()
    {
        //Enemy = GetComponent<NavMeshAgent>();
        PlayerLocation = Enemy.destination;
    }

    void Update()
    {
        if(Vector3.Distance(PlayerLocation, Player.position) > 1.0f)
        {
            PlayerLocation = Player.position;
            Enemy.destination = PlayerLocation;
        }
    }
}
