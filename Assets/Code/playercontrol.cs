using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    protected Joystick joystick_movement;
    protected Joystick joystick_direction;
    protected Joystick[] joysticks;

        void Start()
    {
        joysticks=FindObjectsOfType<Joystick>();
        joystick_movement = joysticks[1];
        joystick_direction = joysticks[0];
        
    }

    
    void Update()
    {
        var rigidbody=GetComponent<Rigidbody>();
        rigidbody.velocity=new Vector3(joystick_movement.Horizontal*PublicVars.speed,rigidbody.velocity.y,joystick_movement.Vertical*PublicVars.speed);

        Vector3 lookDirection = new Vector3(joystick_direction.Vertical, 0, joystick_direction.Horizontal);
        Quaternion lookRotation = Quaternion.LookRotation(lookDirection,  Vector3.up);

        transform.rotation = Quaternion.RotateTowards(lookRotation, transform.rotation, (5 * Time.deltaTime));

    }
}
