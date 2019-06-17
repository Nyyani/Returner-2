using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip jumpSound, coinSound;
    static AudioSource audioSrc;

	// Use this for initialization
	void Start () {

        jumpSound = Resources.Load<AudioClip>("jumpSound");
        coinSound = Resources.Load<AudioClip>("coinSound");

        audioSrc = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jumpSound":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "coinSound":
                audioSrc.PlayOneShot(coinSound);
                break;
        }
    }
}
