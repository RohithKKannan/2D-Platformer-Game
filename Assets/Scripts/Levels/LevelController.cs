using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelController : MonoBehaviour
{
    private Button LevelSelect;
    public string Level;
    void Awake()
    {
        LevelSelect = GetComponent<Button>();
        LevelSelect.onClick.AddListener(LoadLevel);
    }

    private void LoadLevel()
    {
        SceneManager.LoadScene(Level);
    }
}
