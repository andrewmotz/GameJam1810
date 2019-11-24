using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour
{

    public Animator animator;
    public GameObject EndDoor;
    private EndDoorLogic endDoorScript;
    public static int popCount = 0;

    void OnTriggerEnter2D(Collider2D other){
        endDoorScript = EndDoor.GetComponent<EndDoorLogic>();
        Debug.Log("hit");
        animator.SetTrigger("hit");
        endDoorScript.increaseCount();
    }
}
