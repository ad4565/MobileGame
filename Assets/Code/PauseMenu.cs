using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pausemenuUI;

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Pause() {
        pausemenuUI.SetActive(true);
        Time.timeScale=0f;
        PublicVars.GamePaused = true;
    }

    public void Resume() {
        pausemenuUI.SetActive(false);
        Time.timeScale=1f;
        PublicVars.GamePaused = false;
    }
    public void ExitGame(){
        Application.Quit();
    }
}
