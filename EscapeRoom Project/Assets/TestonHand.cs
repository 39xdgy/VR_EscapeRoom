using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class TestonHand : MonoBehaviour {
    Player player;
    Animator anim;
    // Use this for initialization
    void Start () {

    }

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        anim = GetComponent<Animator>();
        //playsound.clip = Sound;
    }
    // Update is called once per frame
    void Update () {
		
	}

    private void FixedUpdate()
    {
        bool test = player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Grip);

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
}
