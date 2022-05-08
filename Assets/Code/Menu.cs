using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame(){ 
        SceneManager.LoadScene("desert");
    }
    public void ExitGame(){
        Application.Quit();
    }
    public void SelectLevel(){
        PublicVars.speed=10;
        PublicVars.score=0;
        PublicVars.enemykilled=0;
        PublicVars.health=5;
        PublicVars.survival = true;
        SceneManager.LoadScene("SelectLevels");
    }

    public void selectlevelback() {
        PublicVars.survival = false;
        SceneManager.LoadScene("Menu");
    }
    public void desert1(){
        Time.timeScale=1f;
        SceneManager.LoadScene("desert");
    }
    public void desert2(){
        Time.timeScale=1f;
        SceneManager.LoadScene("desert2");
    
    }
    public void forest1(){
        Time.timeScale=1f;
        SceneManager.LoadScene("Forest");
    
    }
    public void forest2(){
        Time.timeScale=1f;
        SceneManager.LoadScene("forest2");
    
    }

    public void mainmenu() {
        Time.timeScale=1f;
        PublicVars.survival = false;
        PublicVars.health=5;
        PublicVars.score=0;
        PublicVars.enemykilled=0;
        PublicVars.timeValue =0;
        PublicVars.speed =10;
        PublicVars.fireRate = 1.2f;
        PublicVars.totalenemykilled=0;
        SceneManager.LoadScene("Menu");
    }

    public void retry() {
        Time.timeScale=1f;
        PublicVars.health=5;
        PublicVars.score=0;
        PublicVars.enemykilled=0;
        PublicVars.totalenemykilled=0;
        PublicVars.timeValue =0;
        PublicVars.speed =10;
        PublicVars.fireRate = 1.2f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}