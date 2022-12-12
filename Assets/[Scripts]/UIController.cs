using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// UIController.cs
/// Lucas Gurney
/// 101313633
/// December 11, 2022
/// Used for making UI buttons to transition to different scene
/// Added Buttons
/// </summary>

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnRestartButton_MainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnRestartButton_MainGame()
    {
        SceneManager.LoadScene("Main Game");
    }
    public void OnRestartButton_Instruction()
    {
        SceneManager.LoadScene("Instruction");
    }
    public void OnRestartButton_GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
