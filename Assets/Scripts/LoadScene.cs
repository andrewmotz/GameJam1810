using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int sceneIndex;
    public void loadScene(){
        SceneManager.LoadScene(sceneIndex);
    }
}
