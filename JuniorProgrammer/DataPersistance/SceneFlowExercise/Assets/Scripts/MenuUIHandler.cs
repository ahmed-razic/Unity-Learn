using System.Collections;
using System.Collections.Generic;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputName;
    // Start is called before the first frame update
    void Start()
    {
        MainManager.Instance.inputName = inputName.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSceneOne()
    {
        SceneManager.LoadScene(1);
    }
    
    public void StartSceneTwo()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
