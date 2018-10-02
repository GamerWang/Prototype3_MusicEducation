using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteSlot : MonoBehaviour {
    // editable properties
    public GameObject slotSprite;
    public Sprite noteTexture;

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
            slotSprite.transform.localScale = new Vector3(15, 15, 1);
            var img = slotSprite.GetComponent<Image>();
            img.color = new Color(255, 0, 255);
            img.sprite = noteTexture;
            slotSprite.GetComponent<RectTransform>().anchoredPosition = new Vector2(5, 42);
        }
    }

    public void Reset()
    {
        if (slotSprite != null)
        {
            slotSprite.transform.localScale = Vector3.one;
            var img = slotSprite.GetComponent<Image>();
            img.color = Color.gray;
            img.sprite = null;
            slotSprite.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
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
