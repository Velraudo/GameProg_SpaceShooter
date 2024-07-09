using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(0); // Game Scene
    }

    public void LoadCoOp()
    {
        SceneManager.LoadScene(2);
    }
}
