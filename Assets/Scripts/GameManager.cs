using System;

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Boolean isGameOver = false;
    public GameObject UIPanel;
    public float restartDelay = 1f;
    public void EndGame(){
        if(!isGameOver){
        isGameOver = true;
        Debug.Log("Game Over"); 
        Invoke("RestartGame", restartDelay); // Restart the game after 2 seconds
        }     
    }
    public void CompleteScreen(){
        UIPanel.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LevelComplete()
    {
        Debug.Log("Level Won!");
    }
}
