using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTwoHandler : MonoBehaviour
{
    public TextMeshProUGUI inputName;
    Renderer sphere;

    // Start is called before the first frame update
    void Start()
    {
        inputName.SetText("Welcome to Scene 2 " + MainManager.Instance.inputName);
        sphere = GameObject.Find("Sphere").GetComponent<Renderer>();
        sphere.material.SetColor("_Color", Color.blue);
    }

    // Update is called once per frame
    void Update()
    {

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
