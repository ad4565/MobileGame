using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncreaseSpeed : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public void speedup() {
        if (PublicVars.speed <30 && PublicVars.score >=10) {
            PublicVars.speed+=5;
            PublicVars.score -=10;
            scoreUI.text="Soul: "+PublicVars.score;
        }
        
    }
    
}
