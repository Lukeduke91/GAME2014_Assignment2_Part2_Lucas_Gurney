using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// DeathPlaneController.cs
/// Lucas Gurney
/// 101313633
/// December 11, 2022
/// Made to bring player back to the play area
/// Added Game over transition
/// </summary>

[System.Serializable]
public class DeathPlaneController : MonoBehaviour
{
    public Transform playerSpawnPoint;
    public HealthBarController health;
    void Start()
    {
        health = FindObjectOfType<PlayerHealth>().GetComponent<HealthBarController>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            ReSpawn(collision.gameObject);
            health.TakeDamage(10);
            if(health.value <= 0)
            {
                SceneManager.LoadScene("Game Over");
            }
        }
    }

    public void ReSpawn(GameObject go)
    {
        go.transform.position = playerSpawnPoint.position;
    }
}
