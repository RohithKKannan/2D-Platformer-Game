using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{
    public GameObject LevelCompletePanel;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<PlayerController>() != null)
        {
            LevelManager.Instance.SetLevelComplete();
            LevelCompletePanel.SetActive(true);
        }
    }

}
