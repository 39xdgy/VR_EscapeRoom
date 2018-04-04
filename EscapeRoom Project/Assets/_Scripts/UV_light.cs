using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class UV_light : MonoBehaviour {

    Player player;
    Animator Anim;
    private bool isOn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void Awake()
    {
        Anim = GameObject.Find("fonarik_low_fbx").GetComponent<Animator>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("UV_light"))
        {
                Anim.SetBool("Turn_On", true);
                Anim.SetBool("Turn_Off", false);
            

            



            /**
            if(this.name == "Hand1")
            {
                if (player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Grip) && !isOn)
                {
                    Anim.SetBool("Turn_On", true);
                    Anim.SetBool("Turn_Off", false);
                }
                else
                {
                    Anim.SetBool("Turn_On", false);
                    Anim.SetBool("Turn_Off", true);
                }
            }
            else
            {
                if(player.leftController.GetPressDown(SteamVR_Controller.ButtonMask.Grip) && !isOn)
                {
                    Anim.SetBool("Turn_On", true);
                    Anim.SetBool("Turn_Off", false);
                }
                else
                {
                    Anim.SetBool("Turn_On", false);
                    Anim.SetBool("Turn_Off", true);
                }
            }
            isOn = !isOn;
    **/
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("UV_light"))
        {
            Anim.SetBool("Turn_Off", true);
            Anim.SetBool("Turn_On", false);
        }
    }


}
