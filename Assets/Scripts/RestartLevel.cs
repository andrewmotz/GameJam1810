using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void restartCurrentLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
