using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour
{

    public Animator animator;
    public static int popCount = 0;

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hit");
        animator.SetTrigger("hit");
        popCount++;
    }
}
