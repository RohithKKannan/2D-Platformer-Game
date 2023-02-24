using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject hud;
    [SerializeField] PlayerController player;
    void Start()
    {
        gameOver.SetActive(false);
    }
    public void GameOver()
    {
        hud.SetActive(false);
        gameOver.SetActive(true);
        player.GetComponent<PlayerController>().enabled = false;
    }
    public void RestartLevel()
    {
        HeartController.hearts = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        HeartController.hearts = 3;
        SceneManager.LoadScene(0);
    }
    public void NextLevel()
    {
        LevelManager.Instance.LoadNextLevel();
    }
}
