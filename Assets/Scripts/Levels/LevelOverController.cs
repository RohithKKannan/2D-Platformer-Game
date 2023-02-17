using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{
    public GameObject LevelCompletePanel;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<PlayerController>() != null)
        {
            AudioManager.Instance.PlaySound(SoundType.FinishLevel);
            LevelManager.Instance.SetLevelComplete();
            LevelCompletePanel.SetActive(true);
        }
    }

}
