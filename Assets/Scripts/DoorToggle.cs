using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToggle : MonoBehaviour
{
    public GameObject door;
    public Animator animator;

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Triggered");
        if(other.gameObject.CompareTag("Player 1")){
            door.gameObject.SetActive(false);
            animator.SetTrigger("pressed");
            Debug.Log("Door opened");
        } else if(other.gameObject.CompareTag("Player 2")){
            door.gameObject.SetActive(false);
            animator.SetTrigger("pressed");
            Debug.Log("Door opened");
        } else if(other.gameObject.CompareTag("Pushable")){
            door.gameObject.SetActive(false);
            animator.SetTrigger("pressed");
            Debug.Log("Door opened");
        }
    }

    void OnTriggerExit2D(Collider2D other){
        door.gameObject.SetActive(true);
        animator.SetTrigger("unpressed");
    }
}
