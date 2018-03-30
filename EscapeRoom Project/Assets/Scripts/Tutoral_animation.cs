using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Tutoral_animation : MonoBehaviour
    {
    public BoxCollider keypad;
        Player player;
        Animator anim;
    public AudioClip Sound;
    public AudioSource playsound;
        private void Awake()
        {
            player = GameObject.Find("Player").GetComponent<Player>();
            anim = GetComponent<Animator>();
            playsound.clip = Sound;
        }



        private void FixedUpdate()
        {
            bool test = player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Grip);
            
            anim.SetBool("Open", test);

        bool test2 = player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger);
        if (test2)
        {
            playsound.Play();
            playsound.clip = Sound;
        }
        }

    }
