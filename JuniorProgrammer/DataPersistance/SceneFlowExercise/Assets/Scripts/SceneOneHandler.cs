using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
