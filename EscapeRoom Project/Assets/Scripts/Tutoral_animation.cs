using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Tutoral_animation : MonoBehaviour
    {
    //public BoxCollider keypad;
        Player player;
        Animator anim;
    ControllerButtonPusher script;
    //public GameObject hand;

    private void Start()
    {
       // GameObject Hand2 = GameObject.Find("Hand2");
        //ControllerButtonPusher script = Hand2.GetComponent<ControllerButtonPusher>();
    }
    private void Awake()
        {
            player = GameObject.Find("Player").GetComponent<Player>();
            anim = GetComponent<Animator>();
        GameObject Hand2 = GameObject.Find("Hand2");
        script = Hand2.GetComponent<ControllerButtonPusher>();
        //playsound.clip = Sound;
    }


    private void FixedUpdate()
        {
           // bool test = player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Grip);
        bool test = script.open;
        
       // bool fin = test && hand.
            anim.SetBool("Open", test);
        /**
        bool test2 = player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger);
        if (test2)
        {
            playsound.Play();
            playsound.clip = Sound;
        }
    **/
        }



    //private void OnTriggerEnter(Collider other)
    //{
        
    //}

}
