using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOneHandler : MonoBehaviour
{
    public TextMeshProUGUI inputName;

    // Start is called before the first frame update
    void Start()
    {
        //inputName = GameObject.Find("Input Name Text").GetComponent<TextMeshProUGUI>();
        //inputName.SetText("Welcome " + MainManager.Instance.inputName);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Welcome " + MainManager.Instance.inputName + " (Scene One)");
    }

    public void ToSceneTwo()
    {
        SceneManager.LoadScene(2);
    }
    
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
