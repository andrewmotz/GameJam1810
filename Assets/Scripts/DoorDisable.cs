using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDisable : MonoBehaviour
{
    public GameObject door;
    public Animator animator;

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Triggered");
        if(other.gameObject.CompareTag("Player 1")){
            door.gameObject.SetActive(false);
            Debug.Log("Door opened");
            animator.SetTrigger("pressed");
        } else if(other.gameObject.CompareTag("Player 2")){
            door.gameObject.SetActive(false);
            Debug.Log("Door opened");
            animator.SetTrigger("pressed");
        }
    }
}
