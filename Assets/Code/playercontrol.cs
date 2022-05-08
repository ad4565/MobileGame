using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class playercontrol : MonoBehaviour
{

    public Transform bulletPoint;
    public GameObject bulletPrefab;
    protected Joystick joystick_movement;
    protected Joystick joystick_direction;
    protected Joystick[] joysticks;
    protected Canvas canvas;
    private AudioSource source;
    public AudioSource gunsound;
    
    private Animator anim;
    bool isAlive=true;

    //public float fireRate = 0.5f;
    private float nextFire = 0.0f;
   
    public gameoverUI gameoverUI;

    [SerializeField]private Image [] hearts;
        void Start(){
        source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
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
        //Updatehealth();
    }
    
    // public void Updatehealth(){
    //     for(int i=0;i<hearts.Length;i++){
    //         if(i<PublicVars.health){
    //             hearts[i].color=Color.red;
    //         }
    //         else{
    //             hearts[i].color=Color.black;
    //         }
    //     }
    // }

    
    void Update()
    {
        var rigidbody=GetComponent<Rigidbody>();
        rigidbody.velocity=new Vector3(joystick_movement.Horizontal*PublicVars.speed,rigidbody.velocity.y,joystick_movement.Vertical*PublicVars.speed);
        if ((joystick_movement.Horizontal != 0 || joystick_movement.Vertical != 0) && !(anim.GetCurrentAnimatorStateInfo(0).length > anim.GetCurrentAnimatorStateInfo(0).normalizedTime))
        {
          
                anim.Play("Base Layer.RunFWD_HG01_Anim", 0, 0);
            
        }


        if (joystick_direction.Horizontal != 0 || joystick_direction.Vertical != 0)
        {
            Vector3 lookDirection = new Vector3(joystick_direction.Horizontal, 0, joystick_direction.Vertical);
            Quaternion lookRotation = Quaternion.LookRotation(lookDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(lookRotation, transform.rotation, (5 * Time.deltaTime));
            
            
            if(Time.time >nextFire) {
                nextFire = Time.time +PublicVars.fireRate;
                Shoot();
            }

            

            //Shoot();
        }
        for(int i=0;i<hearts.Length;i++){
            if(i<PublicVars.health){
                hearts[i].color=Color.red;
            }
            else{
                hearts[i].color=Color.black;
            }
        }
    }

    void Shoot()
    {
        gunsound.Play();
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(bulletPoint.forward * 40f, ForceMode.Impulse);
    }
    void FixedUpdate(){
        if(isAlive&&PublicVars.health==0){
            //isAlive=false;
            
            gameoverUI.Setup();
            Time.timeScale=0f;
        }

    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("zombie")) {

        }
    }
}
