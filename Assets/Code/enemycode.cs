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
    void Start()
    {
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
            Destroy(gameObject);
        }
    }

    
    
}

