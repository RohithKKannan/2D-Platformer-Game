using UnityEngine;
using UnityEngine.UI;
public class LobbyController : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject Options;
    [SerializeField] GameObject LevelSelection;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider soundFxSlider;
    void Start()
    {
        musicSlider.value = AudioManager.Instance.GetMusicVolume();
        soundFxSlider.value = AudioManager.Instance.GetSfxVolume();
    }
    public void StartGame()
    {
        LevelSelection.SetActive(true);
        AudioManager.Instance.PlaySound(SoundType.ButtonClick);
    }
    public void OpenOptions()
    {
        Options.SetActive(true);
        AudioManager.Instance.PlaySound(SoundType.ButtonClick);
    }
    public void BackToMenu()
    {
        AudioManager.Instance.PlaySound(SoundType.ButtonClick);
        Options.SetActive(false);
        LevelSelection.SetActive(false);
    }
    public void QuitGame()
    {
        AudioManager.Instance.PlaySound(SoundType.ButtonClick);
        Application.Quit();
    }
}
