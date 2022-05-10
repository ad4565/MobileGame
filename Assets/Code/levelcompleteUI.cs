using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class levelcompleteUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject levelcompleterUI;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI enemyUI;
    public TextMeshProUGUI timeUI;
    public string leveltoload;
    public void Setup(){
        Time.timeScale=0f;
        levelcompleterUI.SetActive(true);
        scoreUI.text="Soul: "+PublicVars.score.ToString();
        enemyUI.text="Enemies Killed: "+PublicVars.totalenemykilled.ToString();
        float minutes = Mathf.FloorToInt(PublicVars.timeValue) / 60;
        float seconds = Mathf.FloorToInt(PublicVars.timeValue) % 60;

        timeUI.text = "Time Survived: "+string.Format("{0:00}:{1:00}",minutes,seconds);
    }

    public void nextlevel() {
         PublicVars.health=5;
            PublicVars.score=0;
            PublicVars.enemykilled=0;
            PublicVars.timeValue =0;
            PublicVars.speed =10;
            PublicVars.firerate = 200;
        Time.timeScale=1f;
        SceneManager.LoadScene(leveltoload);

    }
}
