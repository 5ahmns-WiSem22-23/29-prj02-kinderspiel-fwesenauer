using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AuswahlSceneLoad : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    // Start is called before the first frame update

    public void QuitGame()
    {
        Application.Quit();
    }  
}
