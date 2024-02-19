using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void SetPlayerName()
    {
        ScoreManager.Instance.playerName = nameInputField.textComponent.text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        //MainManager.Instance.SaveHighScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}

