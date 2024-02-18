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
        if (MainManager.Instance.inputName.Length != 0)
        {
            //inputNameField.transform.Find("Text Area").transform.Find("Placeholder").GetComponent<TMP_Text>().gameObject.SetActive(false);
            inputNameField.gameObject.SetActive(false);
            welcome.gameObject.SetActive(true);
            welcome.SetText("Welcome " + MainManager.Instance.inputName);
        }
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
