using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeModeKey : MonoBehaviour {
    // editable properties
    public TrebleNoteType type;

    // public functions
    public void Press()
    {
        if(type != TrebleNoteType._Default)
        {
            FreeColumnWrapper._AddNewNote(type);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
