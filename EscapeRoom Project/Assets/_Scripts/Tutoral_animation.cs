using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Tutoral_animation : MonoBehaviour
    {
    //create player, animation, scripts on both hand
    Player player;
    Animator anim;
    ControllerButtonPusher script2;
    ControllerButtonPusher script1;
    //two public string so that we can change the input from unity
    public string code;
    public string rightcode;

    //setup when the game start, 1. controller 2. animation 3. script from left and right hand
    private void Awake()
       {
        player = GameObject.Find("Player").GetComponent<Player>();
        anim = GetComponent<Animator>();
        GameObject Hand2 = GameObject.Find("Hand2");
        GameObject Hand1 = GameObject.Find("Hand1");
        script2 = Hand2.GetComponent<ControllerButtonPusher>();
        script1 = Hand1.GetComponent<ControllerButtonPusher>();
    }

    // check every second the boolean of the door
    private void FixedUpdate()
        {
        bool test = script2.open || script1.open;
        anim.SetBool("Open", test);
        }
}
