using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingNote : MonoBehaviour {
    // editable properties
    public GameObject noteImage;
    public int _colliderBoxSize = 10;

    // public references & variables
    public TrebleNoteType slotNoteType { get; set; }
    public Collider2D slotCollider { get; set; }
    public bool hitSlot { get; set; }

    // private references & variables

    // Use this for initialization
    void Start () {
        slotNoteType = TrebleNoteType._Default;
        hitSlot = false;
	}
	
	// Update is called once per frame
	void Update () {
        var centerPosition = new Vector2(transform.position.x, transform.position.y);
        var bottomLeftCorner = centerPosition - new Vector2(10, 10);
        var upperRightCorner = centerPosition + new Vector2(10, 10);
        var slotHitted = Physics2D.OverlapArea(bottomLeftCorner, upperRightCorner);

        hitSlot = false;
        if (slotHitted != null)
        {
            if(slotHitted.gameObject.tag == "NoteSlot")
            {
                hitSlot = true;
            }
        }

        if (hitSlot)
        {
            slotCollider = slotHitted;
            var slotPosition = slotHitted.transform.position;
            noteImage.transform.position = slotPosition;
            slotNoteType = slotHitted.GetComponent<NoteSlot>().noteType;
        }
        else
        {
            slotNoteType = TrebleNoteType._Default;
            if(noteImage != null)
            {
                noteImage.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            }
        }
	}
}
