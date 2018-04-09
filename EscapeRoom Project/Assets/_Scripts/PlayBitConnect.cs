using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBitConnect : MonoBehaviour {

    public AudioClip clip;

    void Start()
    {
        
    }
	// Use this for initialization


    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(clip, new Vector3(-4.33f, 0.24f, -1.22f));
    }




	// Update is called once per frame
	void Update () {
		
	}
}
