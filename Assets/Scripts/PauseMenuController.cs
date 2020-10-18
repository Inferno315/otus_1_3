using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{

    public CanvasGroup pauseOverlay;
    

    void Start() {
        Utility.SetCanvasGroupEnabled(pauseOverlay, false);
    }
    public void OnResumePressed(){
        Utility.SetCanvasGroupEnabled(pauseOverlay, false);
    }

    public void OnRestartPressed(){
        LoadingScreen.instance.ReloadLastLoadedScene();
    }

    public void OnExitPressed(){
        LoadingScreen.instance.LoadScene("MainMenu");
    }

    
}
