using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemycode : MonoBehaviour
{
    NavMeshAgent _navAgent;
    GameObject player;
    Vector3 offset;
    public float amount;
    float distance;
    bool follow=true;
    public static int enemyhealth;
    public float timeValue = 0;
    void Start()
    {
        if ((Mathf.FloorToInt(PublicVars.timeValue) / 60) ==0) {
            enemyhealth = 1;
        } else {
            enemyhealth = (Mathf.FloorToInt(PublicVars.timeValue) / 60);
        }
        
        
       _navAgent=GetComponent<NavMeshAgent>(); 
       player=GameObject.FindGameObjectWithTag("Player");
       StartCoroutine(FindPlayer());
    }
    
    IEnumerator FindPlayer(){
        player=GameObject.FindGameObjectWithTag("Player");
        while(follow){
            yield return new WaitForSeconds(.1f);
            _navAgent.destination=player.transform.position;
        }

    }
    private void Update(){
        if (PublicVars.GamePaused ==false) {
            timeValue +=Time.deltaTime;
        }
        // player=GameObject.FindGameObjectWithTag("Player");
        // var distance = Vector3.Distance(player.transform.position, transform.position);
        // if (distance <=amount) {
        //     follow = true;
        //     StartCoroutine(FindPlayer());
        // }
        // else {
        //     follow = false;
        //     StartCoroutine(FindPlayer());
        // }
    }

    
    // private void OnCollisionEnter(Collision other){
    //     if(other.gameObject.CompareTag("Bullet")){
    //         Destroy(other.gameObject);
    //         Destroy(gameObject);
    //     }
    // }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Bullet")){
            Destroy(other.gameObject);
            if (enemyhealth ==1) {
                Destroy(gameObject);
                PublicVars.enemykilled++;
                PublicVars.totalenemykilled++;
            } else {
                enemyhealth -=1;
            }
            
            
        }
    }

    
    
}

