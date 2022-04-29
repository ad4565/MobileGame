using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class playercontrol : MonoBehaviour


{

    public Transform bulletPoint;
    public GameObject bulletPrefab;
    protected Joystick joystick_movement;
    protected Joystick joystick_direction;
    protected Joystick[] joysticks;
    protected Canvas canvas;
    bool isAlive=true;

    



        void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        joysticks=FindObjectsOfType<Joystick>();

        if(joysticks[0].name.Equals("Movement Joystick"))
        {
            joystick_movement = joysticks[0];
            joystick_direction = joysticks[1];

        }
        else
        {
            joystick_movement = joysticks[1];
            joystick_direction = joysticks[0];
        }

 
    }

    
    void Update()
    {
        var rigidbody=GetComponent<Rigidbody>();
        rigidbody.velocity=new Vector3(joystick_movement.Horizontal*PublicVars.speed,rigidbody.velocity.y,joystick_movement.Vertical*PublicVars.speed);



        if (joystick_direction.Horizontal != 0 || joystick_direction.Vertical != 0)
        {
            Vector3 lookDirection = new Vector3(joystick_direction.Vertical, 0, joystick_direction.Horizontal);
            Quaternion lookRotation = Quaternion.LookRotation(lookDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(lookRotation, transform.rotation, (5 * Time.deltaTime));

            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(bulletPoint.forward * 40f, ForceMode.Impulse);
    }
    void FixedUpdate(){
        if(isAlive&&PublicVars.health==0){
            isAlive=false;
            PublicVars.health=5;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
