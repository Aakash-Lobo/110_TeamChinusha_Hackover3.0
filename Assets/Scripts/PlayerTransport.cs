using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransport : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void OnCollisionEnter(Collision Other)
    {
        player.transform.position = respawnPoint.transform.position;
    }
}
