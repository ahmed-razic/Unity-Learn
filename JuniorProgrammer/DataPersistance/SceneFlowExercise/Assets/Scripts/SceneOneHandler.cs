using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOneHandler : MonoBehaviour
{
    public TextMeshProUGUI inputName;
    Renderer cube;

    // Start is called before the first frame update
    void Start()
    {
        inputName.SetText(MainManager.Instance.inputName + ", welcome to scene 1");
        cube = GameObject.Find("Cube").GetComponent<Renderer>();
        cube.material.SetColor("_Color", Color.green);
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
