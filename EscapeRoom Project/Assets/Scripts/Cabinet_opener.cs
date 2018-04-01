﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Cabinet_opener : MonoBehaviour {
    Player player;
    Animator anim;
    private bool isOpen = false;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hand") && (player.leftController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger) || player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))){
            if (!isOpen)
            {
                anim.SetBool("Open", true);
            }
            else
            {
                anim.SetBool("Close",true);
            }
            isOpen = !isOpen;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
