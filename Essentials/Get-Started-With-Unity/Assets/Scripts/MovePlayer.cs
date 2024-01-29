using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class MovePlayer : MonoBehaviour
{
    public string messageStart = null;
    public string messageUpdate = null;
    //[SerializeField] private Vector3 translateChange;
    //[SerializeField] private Vector3 rotateChange;
    //[SerializeField] private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(messageStart);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += translateChange;
        //transform.Rotate(rotateChange, 1.0f);
        //transform.localScale += scaleChange;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}