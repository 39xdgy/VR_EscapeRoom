using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Tutoral_animation : MonoBehaviour
    {
    //public BoxCollider keypad;
        Player player;
        Animator anim;
    ControllerButtonPusher script2;
    ControllerButtonPusher script1;
    public string code;
    public string rightcode;
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
        GameObject Hand1 = GameObject.Find("Hand1");
        script2 = Hand2.GetComponent<ControllerButtonPusher>();
        script1 = Hand1.GetComponent<ControllerButtonPusher>();
        //playsound.clip = Sound;
    }


    private void FixedUpdate()
        {
           // bool test = player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Grip);
        bool test = script2.open || script1.open;
        
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
