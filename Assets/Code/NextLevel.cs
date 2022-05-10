using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    public string leveltoload;
    public levelcompleteUI levelcompleteUI;
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")&&PublicVars.score>=50 && PublicVars.survival == false){
            levelcompleteUI.Setup();
            Time.timeScale=0f;
            //SceneManager.LoadScene(leveltoload);
        }
    }
}
