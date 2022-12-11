using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
