using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioClip clip_C4, clip_D4, clip_E4, clip_F4, clip_G4, clip_A4, clip_B4, clip_C5;

    public AudioSource AudioObject;

    // Use this for initialization
    void Start () {
       
	}

	// Update is called once per frame
	void Update () {
		
	}

   public void PlaySingleKey(string key)
    {
        string keyCode = key;

        switch (keyCode)
        {
            case "C4":
                AudioObject.clip = clip_C4;
                break;
            case "D4":
                AudioObject.clip = clip_D4;
                break;
            case "E4":
                AudioObject.clip = clip_E4;
                break;
            case "F4":
                AudioObject.clip = clip_F4;
                break;
            case "G4":
                AudioObject.clip = clip_G4;
                break;
            case "A4":
                AudioObject.clip = clip_A4;
                break;
            case "B4":
                AudioObject.clip = clip_B4;
                break;
            case "C5":
                AudioObject.clip = clip_C5;
                break;

        }

        AudioObject.Play();
    }
}
