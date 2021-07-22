using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentsceneindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentsceneindex + 1);
    }
    public  void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadStartingcene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadScorecene()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadSecondcene()
    {
        SceneManager.LoadScene(1);
    }
    public void Loadchoosecar()
    {
        SceneManager.LoadScene(4);
    }
    
    public void Loadhighscore()
    {
        SceneManager.LoadScene(5);
    }
    public void Loadthirdscene()
    {
        SceneManager.LoadScene(2);
    }


    public void Loadmainmenu()
    {
        SceneManager.LoadScene(3);
    }

    public void quit()
    {
        Application.Quit();
    }
}
