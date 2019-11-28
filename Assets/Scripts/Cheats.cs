using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheats : MonoBehaviour
{
    private KeyCode ctrlKey = KeyCode.LeftShift;
    private KeyCode zKey = KeyCode.M;
    private KeyCode oneKey = KeyCode.Alpha1;
    private KeyCode twoKey = KeyCode.Alpha2;
    private KeyCode threeKey = KeyCode.Alpha3;
    private KeyCode fourKey = KeyCode.Alpha4;
    private KeyCode fiveKey = KeyCode.Alpha5;
    private KeyCode sixKey = KeyCode.Alpha6;
    private KeyCode sevenKey = KeyCode.Alpha7;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(zKey) && Input.GetKey(ctrlKey)){
            Debug.Log("Cheat keys pressed...");
            if(Input.GetKey(oneKey)){
                Debug.Log("Loading Scene 1");
                SceneManager.LoadScene(1);
            }
            if(Input.GetKey(twoKey)){
                SceneManager.LoadScene(2);
            }
            if(Input.GetKey(threeKey)){
                SceneManager.LoadScene(3);
            }
            if(Input.GetKey(fourKey)){
                SceneManager.LoadScene(4);
            }
            if(Input.GetKey(fiveKey)){
                SceneManager.LoadScene(5);
            }
            if(Input.GetKey(sixKey)){
                SceneManager.LoadScene(6);
            }
            if(Input.GetKey(sevenKey)){
                SceneManager.LoadScene(7);
            }

        }
    }
}
