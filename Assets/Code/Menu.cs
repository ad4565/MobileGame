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
        SceneManager.LoadScene("SelectLevel");
    }
}