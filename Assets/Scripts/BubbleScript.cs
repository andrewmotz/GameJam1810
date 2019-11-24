using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour
{

    public Animator animator;
    public GameObject EndDoor;
    private EndDoorLogic endDoorScript;
    private bool isTriggered = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        endDoorScript = EndDoor.GetComponent<EndDoorLogic>();
        Debug.Log("hit");
        animator.SetTrigger("hit");
        if (!isTriggered)
        {
            endDoorScript.increaseCount();
            isTriggered = true;
        }
    }
}
