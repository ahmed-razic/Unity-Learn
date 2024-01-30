using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public bool changeView = true;
    private Vector3 offset1 = new(0, 10, -15);
    private Vector3 offset2 = new(0, 3, 3);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            changeView = !changeView;
        }

        if (changeView)
        {
            transform.position = player.transform.position + offset1;
        }
        else if (!changeView)
        {
            transform.position = player.transform.position + offset2;
        }
    }
}
