using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteSlot : MonoBehaviour {
    // editable properties
    public GameObject slotSprite;

    // public references & variables
    public TrebleNoteType noteType { get; set; }

    // private references & variables
    NoteColumn parentColumn { get; set; }

    // public functions
    public void Drop()
    {
        if (parentColumn != null)
        {
            parentColumn.ResetAllNotes();
            parentColumn.SetCurrentNote(noteType);
        }
        if(slotSprite != null)
        {
            slotSprite.transform.localScale = new Vector3(2, 2, 2);
            slotSprite.GetComponent<Image>().color = new Color(255, 0, 255);
        }
    }

    public void Reset()
    {
        if (slotSprite != null)
        {
            slotSprite.transform.localScale = Vector3.one;
            slotSprite.GetComponent<Image>().color = Color.gray;
        }
    }

    // customize Initialization
    public void Init(NoteColumn parent, TrebleNoteType type = TrebleNoteType._Default)
    {
        parentColumn = parent;
        noteType = type;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
