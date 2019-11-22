using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void gameQuit()
    {
        Debug.Log("Quitting...");
        Application.Quit(0);
    }
}
