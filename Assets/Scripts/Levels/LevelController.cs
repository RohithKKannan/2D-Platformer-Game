using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelController : MonoBehaviour
{
    private Button LevelSelect;
    public int levelIndex;
    void Awake()
    {
        LevelSelect = GetComponent<Button>();
        LevelSelect.onClick.AddListener(LoadLevel);
        if (LevelManager.Instance.GetLevelStatus(levelIndex) == LevelStatus.locked)
            GetComponent<Image>().color = Color.grey;
        else
            GetComponent<Image>().color = Color.white;
    }

    private void LoadLevel()
    {
        LevelManager.Instance.LoadLevel(levelIndex);
    }
}
