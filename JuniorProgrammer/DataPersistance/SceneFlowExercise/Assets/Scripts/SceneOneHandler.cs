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
        inputName.SetText("Welcome to scene 1 " + MainManager.Instance.inputName);        
    }

    // Update is called once per frame
    void Update()
    {

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
