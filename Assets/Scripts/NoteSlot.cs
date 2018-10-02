using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSlot : MonoBehaviour {
    // public references & variables
    public TrebleNoteType noteType { get; set; }

    // customize Initialization
    public void Init(TrebleNoteType type = TrebleNoteType._Default)
    {
        noteType = type;
        // DEBUG
        Debug.Log("NoteSlot: see note Type: " + noteType);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
