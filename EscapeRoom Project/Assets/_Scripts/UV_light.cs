using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class UV_light : MonoBehaviour {
	//create the value of player for controller, the animation and the boolean of the flashlight
    Player player;
    Animator Anim;
    private bool isOn = false;
	//setup the animation and player object
    private void Awake()
    {
        Anim = GameObject.Find("fonarik_low_fbx").GetComponent<Animator>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }
	// when it enter the trigger, turn on the flashlight
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("UV_light"))
        {
            Anim.SetBool("Turn_On", true);
            Anim.SetBool("Turn_Off", false);
        }
    }
	//when it exit the trigger, turn off the flashlight
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("UV_light"))
        {
            Anim.SetBool("Turn_Off", true);
            Anim.SetBool("Turn_On", false);
        }
    }


}
