using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ErklärungsManagerScript : MonoBehaviour
{
    public void EnterGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
