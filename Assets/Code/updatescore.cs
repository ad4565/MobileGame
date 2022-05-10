using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class updatescore : MonoBehaviour
{
    public AudioClip opensound;
    AudioSource _audioSource;
    public TextMeshProUGUI scoreUI;
    private void Start(){
        _audioSource=GetComponent<AudioSource>();
        scoreUI.text="Soul: "+PublicVars.score;
    }
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            _audioSource.PlayOneShot(opensound);
            PublicVars.score+=PublicVars.enemykilled;
            PublicVars.enemykilled=0;
            scoreUI.text="Soul: "+PublicVars.score;
        }
    }
    
}
