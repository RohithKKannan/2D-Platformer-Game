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
        AudioManager.Instance.PlaySound(SoundType.GameOver);
        hud.SetActive(false);
        gameOver.SetActive(true);
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponent<Animator>().enabled = false;
    }
    public void RestartLevel()
    {
        AudioManager.Instance.PlaySound(SoundType.ButtonClick);
        AudioManager.Instance.PlaySound(SoundType.BGMusic);
        HeartController.hearts = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        AudioManager.Instance.PlaySound(SoundType.ButtonClick);
        HeartController.hearts = 3;
        SceneManager.LoadScene(0);
    }
    public void NextLevel()
    {
        AudioManager.Instance.PlaySound(SoundType.ButtonClick);
        LevelManager.Instance.LoadNextLevel();
    }
}
