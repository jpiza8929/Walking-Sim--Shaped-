using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    public float speed;

    public float upRotation;
    public float downRotation;

    CharacterController characterControl;
    
    ItemInfo iteminfo;
    
    public Transform playerCam;

    Vector3 velocity;

    public float lookSensitivity;

    float xRotation;

    public TMP_Text itemText;
    public string lookingAt = "nothing";

    public bool hasKey;

    
    AudioSource myAudiosource;  
    public AudioClip KeySound;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //get the charactercontroller component so you can be able to use it//
        //locks the cursor at the start of the game//
        //gain access to the audiosource on the player in the inspector tab//
        characterControl = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        itemText.text = lookingAt;
        hasKey = false;
        myAudiosource = GetComponent<AudioSource>();
       
       
      }



    // Update is called once per frame
    void Update()
    {
      //these line of code are to rotate the player as the camera rotates, camera sensitivity, etc.//
      
      transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0);
      xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
      xRotation = Mathf.Clamp(xRotation, -upRotation, downRotation);
      playerCam.localRotation = Quaternion.Euler(xRotation,0,0);

      velocity.x = Input.GetAxis("Vertical") * speed;
      velocity.z = Input.GetAxis("Horizontal") * speed;

      velocity = transform.TransformDirection(velocity);
      characterControl.Move(velocity * Time.deltaTime);

    
    }

    //Custom function that plays the ding sound//
    public void playsound()
    {
      
       myAudiosource.PlayOneShot(KeySound);
      }
    }

   


    

  

    

