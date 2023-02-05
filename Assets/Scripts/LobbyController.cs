using UnityEngine;
public class LobbyController : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject Options;
    [SerializeField] GameObject LevelSelection;
    public void StartGame()
    {
        LevelSelection.SetActive(true);
    }
    public void OpenOptions()
    {
        Options.SetActive(true);
    }
    public void BackToMenu()
    {
        Options.SetActive(false);
        LevelSelection.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
