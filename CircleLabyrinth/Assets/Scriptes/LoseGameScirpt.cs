using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoseGameScirpt : MonoBehaviour
{
    private TextMeshProUGUI levelCompleteText;
    void Start()
    {
        TextMeshProUGUI[] allTexts = FindObjectsOfType<TextMeshProUGUI>();
        foreach (TextMeshProUGUI text in allTexts)
        {
            if (text.gameObject.tag == "GameOver")
                levelCompleteText = text;
        }
        int levels = GameMapScript.Level() - 1;
        levelCompleteText.text = "YOU PASSED " + levels + " LEVELS";
    }

    public void TryAgain()
    {
        GameMapScript.RestartGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
