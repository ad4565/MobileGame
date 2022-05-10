using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI timeText;
    

    // Update is called once per frame
    void Update()
    {
        if (PublicVars.GamePaused ==false) {
            PublicVars.timeValue +=Time.deltaTime;
        }
        DisplayTime(PublicVars.timeValue);
    }

    void DisplayTime(float timeToDisplay) {
        float minutes = Mathf.FloorToInt(timeToDisplay) / 60;
        float seconds = Mathf.FloorToInt(timeToDisplay) % 60;

        timeText.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
