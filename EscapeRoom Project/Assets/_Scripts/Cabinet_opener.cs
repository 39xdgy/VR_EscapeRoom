using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Cabinet_opener : MonoBehaviour {
    //we are going to use player for the controller, the animator, and a boolean to chack the door is open or not
    Player player;
    Animator anim;
    // by defalt the door is closed
    private bool isOpen = false;
    
    //setup the the valueable of player and get the animation
    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        anim = GetComponent<Animator>();
    }
    // the program will call this function when it trigger with object
    private void OnTriggerStay(Collider other)
    {
	// the only thing can get in is controller and pull the trigger at the same time
        if(other.gameObject.CompareTag("Hand") && (player.leftController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger) || player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)))
        {
	    // open the door when it close
            if (!isOpen)
            {
                anim.SetBool("Open", true);
                anim.SetBool("Close", false);
            }
	    // close the door when it open
            else
            {
                anim.SetBool("Close",true);
                anim.SetBool("Open", false);
            }
	    // update the door state
            isOpen = !isOpen;
        }
    }
}
