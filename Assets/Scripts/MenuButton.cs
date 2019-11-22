using UnityEngine;

public class MenuButton : MonoBehaviour
{

    public GameObject button1;
    public GameObject button2;
    private bool toggled = false;
    // Start is called before the first frame update
    void Start(){
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
    }
    public void ToggleMenu(){
        if(toggled){
            button1.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
            toggled = false;
        }else{
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            toggled = true;
        }
    }
}
