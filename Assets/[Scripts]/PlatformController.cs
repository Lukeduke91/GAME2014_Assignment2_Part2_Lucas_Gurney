using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

/// <summary>
/// PlatformController.cs
/// Lucas Gurney
/// 101313633
/// November 20, 2022
/// Used for the moving the player back and forth on the platform
/// Added enter and exit collision
/// </summary>

public class PlatformController : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(transform);
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
}
