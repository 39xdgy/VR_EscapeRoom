using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBitConnect : MonoBehaviour {
	//get the sound clip from the object
    public AudioClip clip;
	// when object collide with this object, play the sound(BitConnect!!!!!!!!!!!!!!!!!!!!!!!!!)
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(clip, new Vector3(-4.33f, 0.24f, -1.22f));
    }
}
