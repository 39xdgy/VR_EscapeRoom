using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Animation_Chest : MonoBehaviour {
    Player player;
    Animator anim;

    // Use this for initialization
    // void Start () {

    //}

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        anim = GetComponent<Animator>();
        GameObject Hand2 = GameObject.Find("Hand2");
        //script = Hand2.GetComponent<ControllerButtonPusher>();
        //playsound.clip = Sound;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            anim.SetBool("Open_chest", true);
        }
    }




    private void FixedUpdate()
    {
        //if (player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
          //  anim.SetBool("Open_chest", true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
