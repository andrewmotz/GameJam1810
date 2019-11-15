using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDisable : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject door;
    //public GameObject button;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Triggered");
        if(other.gameObject.CompareTag("Player 1")){
            door.gameObject.SetActive(false);
            Debug.Log("Door opened");
        } else if(other.gameObject.CompareTag("Player 2")){
            door.gameObject.SetActive(false);
            Debug.Log("Door opened");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
