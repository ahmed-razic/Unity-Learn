using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    //public TMP_InputField nameInputField;
    public string playerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

