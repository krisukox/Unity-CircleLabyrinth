using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CompleteLevelScript : MonoBehaviour
{
    private TextMeshProUGUI levelCompleteText;
    void Start()
    {
        TextMeshProUGUI[] allTexts = FindObjectsOfType<TextMeshProUGUI>();
        foreach (TextMeshProUGUI text in allTexts)
        {
            if (text.gameObject.tag == "LevelComplete")
                levelCompleteText = text;
        }
        levelCompleteText.text = "LEVEL " + GameMapScript.Level() + " COMPLETE";
    }

    public void NextLevel()
    {
        GameMapScript.NextLevel();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}