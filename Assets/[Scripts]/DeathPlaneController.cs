using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// DeathPlaneController.cs
/// Lucas Gurney
/// 101313633
/// November 19, 2022
/// Used when the player falls off the level
/// Made the Death Plane
/// </summary>

[System.Serializable]
public class DeathPlaneController : MonoBehaviour
{
    public Transform playerSpawnPoint;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            ReSpawn(collision.gameObject);
        }
    }

    public void ReSpawn(GameObject go)
    {
        go.transform.position = playerSpawnPoint.position;
    }
}
