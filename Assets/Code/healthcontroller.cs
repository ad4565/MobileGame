using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthcontroller : MonoBehaviour
{
    [SerializeField]private Image [] hearts;
    private void Start(){
        Updatehealth();
    }
    public void Updatehealth(){
        for(int i=0;i<hearts.Length;i++){
            if(i<PublicVars.health){
                hearts[i].color=Color.red;
            }
            else{
                hearts[i].color=Color.black;
            }
        }
    }
}
