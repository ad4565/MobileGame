using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private int enemydamage;
    [SerializeField] private healthcontroller _healthcontroller;
    private void OnTriggerEnter(Collider collision){
        if(collision.CompareTag("Player")){
            Damage1();
        }
    }
    void Damage1(){
        PublicVars.health-=enemydamage;
        _healthcontroller.Updatehealth();
    }
}
