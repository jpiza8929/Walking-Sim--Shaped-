using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public string itemName;

    public string notlooking;
    
    public int itemValue;

    PlayerControl playerScript;

   
    
    // Start is called before the first frame update
    void Start()
    {
    
     
      //Access the playercontrol script//
     playerScript = GameObject.Find("Player").GetComponent<PlayerControl>();  
     
     
     
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    

   
     
     //when the mouse is on the key gameobject, the key text will display//
     void OnMouseOver()
    {
     
     Debug.Log(itemName);
     playerScript.itemText.text = itemName;
   
    }

    
    //when the mouse is off the key gameobject the key text won't display anymore//  
    void OnMouseExit()
    {
     
     Debug.Log(notlooking);
     playerScript.itemText.text = notlooking;
    
    }

   // When the haskey variable is true, destroy the key gameobject//
   //Access the playsound function from the player script//  
     void OnMouseDown()
     {
        playerScript.hasKey = true;
        Destroy(this.gameObject);
        playerScript.playsound();


        

     }


        
    
    
}

