using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTwoHandler : MonoBehaviour
{
    public TextMeshProUGUI inputName;

    // Start is called before the first frame update
    void Start()
    {
        //inputName = GameObject.Find("Input Name Text").GetComponent<TextMeshProUGUI>();
        //inputName.SetText("Welcome " + MainManager.Instance.inputName);
        Debug.Log("Welcome " + MainManager.Instance.inputName + " (Scene Two)");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Welcome " + MainManager.Instance.inputName + " (Scene Two)");
    }

    public void ToSceneOne()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
