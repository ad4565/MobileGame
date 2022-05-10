using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameoverUI : MonoBehaviour
{
    public GameObject gameoverrUI;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI enemyUI;
    public TextMeshProUGUI timeUI;

    public void Setup(){
        gameoverrUI.SetActive(true);
        scoreUI.text="Soul: "+PublicVars.score.ToString();
        enemyUI.text="Enemies Killed: "+PublicVars.totalenemykilled.ToString();
        float minutes = Mathf.FloorToInt(PublicVars.timeValue) / 60;
        float seconds = Mathf.FloorToInt(PublicVars.timeValue) % 60;

        timeUI.text = "Time Survived: "+string.Format("{0:00}:{1:00}",minutes,seconds);
    }
    // Start is called before the first frame update

}
