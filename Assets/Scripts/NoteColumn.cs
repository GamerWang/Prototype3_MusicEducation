using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteColumn : MonoBehaviour {
    // editable properties
    public GameObject noteSlotPrefab;
    public int _noteInterval = 25;

    // public references & variables
    public int _columnID { get; set; }
    public List<GameObject> noteSlotList { get; set; }
    public TrebleNoteType _currenetNoteType { get; set; }

    // private references & variables
    int _noteCount = 8;

    // public functions
    public TrebleNoteType GetActiveNote()
    {
        return TrebleNoteType._Default;
    }

    public void ResetAllNotes()
    {
        if(noteSlotList!= null)
        {
            foreach(var n in noteSlotList)
            {
                var s = n.GetComponent<NoteSlot>();
                s.Reset();
            }
        }
    }

    public void SetCurrentNote(TrebleNoteType t)
    {
        _currenetNoteType = t;
    }

    // customize initialization
    public void Init(int id = -1)
    {
        _columnID = id;
        _currenetNoteType = TrebleNoteType._Default;

        if(noteSlotList == null)
        {
            noteSlotList = new List<GameObject>();
        }

        if(noteSlotList.Count > 0)
        {
            foreach(var n in noteSlotList)
            {
                Destroy(n);
            }
            noteSlotList.Clear();
        }

        if (noteSlotPrefab != null)
        {
            for(var i = 0; i< _noteCount; i++)
            {
                var newSlot = Instantiate(noteSlotPrefab);
                newSlot.transform.SetParent(this.transform);
                newSlot.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, i * _noteInterval);

                var slot = newSlot.GetComponent<NoteSlot>();
                slot.Init(this, (TrebleNoteType)i);

                newSlot.SetActive(true);
                noteSlotList.Add(newSlot);
            }
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
