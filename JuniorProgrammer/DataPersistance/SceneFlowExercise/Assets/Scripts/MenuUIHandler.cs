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
    public TMP_InputField inputNameField;
    public TextMeshProUGUI welcome;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void AddName()
    {
        MainManager.Instance.inputName = inputNameField.textComponent.text;        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SaveNameClicked()
    {
        MainManager.Instance.SaveName();
        DisplayName();
    }

    public void LoadNameClicked()
    {
        MainManager.Instance.LoadName();
        DisplayName();
    }

    public void DisplayName()
    {
        //inputNameField.gameObject.SetActive(false);
        welcome.gameObject.SetActive(true);
        welcome.SetText("Welcome " + MainManager.Instance.inputName);
    }

    public void NewName()
    {
        MainManager.Instance.DeleteName();
        //inputNameField.gameObject.SetActive(true);
        welcome.gameObject.SetActive(false);
    }
    public void StartSceneOne()
    {
        SceneManager.LoadScene(1);
    }

    public void StartSceneTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        MainManager.Instance.SaveName();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
