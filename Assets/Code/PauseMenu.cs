using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pausemenuUI;
    public GameObject upgradeMenuUI;

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Pause() {
        upgradeMenuUI.SetActive(false);
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

    public void upgradeMenu() {
        pausemenuUI.SetActive(false);
        upgradeMenuUI.SetActive(true);
    }

    
}
