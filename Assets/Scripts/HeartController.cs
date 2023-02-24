using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HeartController : MonoBehaviour
{
    [SerializeField] GameOverController gameOverController;
    public static int hearts = 3;
    [SerializeField] private TMP_Text heartText;
    void Awake()
    {
        heartText = GetComponent<TMP_Text>();
        UpdateHearts();
    }
    public void TakeDamage()
    {
        hearts--;
        UpdateHearts();
        if (hearts == 0)
        {
            gameOverController.GameOver();
        }
    }
    void UpdateHearts()
    {
        heartText.text = "Hearts : " + hearts;
    }
}
