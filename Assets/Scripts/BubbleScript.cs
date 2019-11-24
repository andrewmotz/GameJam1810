using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour
{

    public Animator animator;
    public GameObject GOendDoor;
    private EndDoorLogic endDoor;
    public static int popCount = 0;

    void OnTriggerEnter2D(Collider2D other){
        endDoor = GOendDoor.GetComponent<EndDoorLogic>();
        Debug.Log("hit");
        animator.SetTrigger("hit");
        endDoor.increaseCount();
    }
}
