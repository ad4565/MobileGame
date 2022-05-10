using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class increasefirerate : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public void firerate() {
        if (PublicVars.fireRate >=0.2f && PublicVars.score >=10) {
            PublicVars.fireRate -= (PublicVars.fireRate * 0.1f);
            PublicVars.score -=10;
            scoreUI.text="Soul: "+PublicVars.score;
        }
        
    }
}
