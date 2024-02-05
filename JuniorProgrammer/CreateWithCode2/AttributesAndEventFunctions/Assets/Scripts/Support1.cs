using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support1 : MonoBehaviour
{
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        //Debug.Log(PlayerController.myIncome);
        //Debug.Log(PlayerController.myIncomePrivate);
        //Debug.Log(playerController.myName);
        
        //playerController.turnSpeed;     turnSpeed and forwardSpeed inaccessible due to its protection level - private
        //playerController.forwardSpeed;  turnSpeed and forwardSpeed inaccessible due to its protection level - private

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Debug.Log(playerController.currentPosition.ToString());
        transform.position = playerController.currentPosition + new Vector3(6, -0.5f, 0);
    }
}
