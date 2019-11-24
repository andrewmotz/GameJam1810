using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToggle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject door;
    public AudioSource PressSound;
    public Animator animator;
    //public GameObject button;

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Toggle Button triggered");
        if (!PressSound.isPlaying)
            {
                PressSound.Play();
            }
        animator.SetTrigger("pressed");
    }

    void OnTriggerExit2D(Collider2D other){
        door.gameObject.SetActive(true);
        animator.SetTrigger("unpressed");
    }
}
