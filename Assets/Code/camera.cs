using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject player;
    Vector3 offset;
    // Start is called before the first frame update
    private Quaternion rotation;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
        rotation = transform.rotation;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = rotation;
        transform.position = player.transform.position + offset;
        //dwtransform.position = player.transform.position; //this would be first person
    }
}
