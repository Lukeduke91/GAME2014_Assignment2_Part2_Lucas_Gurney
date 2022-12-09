using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CheckPoint.cs
/// Lucas Gurney
/// 101313633
/// November 20, 2022
/// Used with death plane to bring players back to the platform they were on
/// Made the CheckPoint
/// </summary>

public class CheckPoint : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            FindObjectOfType<DeathPlaneController>().playerSpawnPoint = transform;
        }
    }
}
