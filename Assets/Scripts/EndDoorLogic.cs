using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoorLogic : MonoBehaviour
{

    public int popThersehold;
    public GameObject toDisable;
    

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Pop count is " + BubbleScript.popCount);
        if(BubbleScript.popCount  >= popThersehold){
            Debug.Log("End door opened");
            toDisable.gameObject.SetActive(false);
        }
    }
}
