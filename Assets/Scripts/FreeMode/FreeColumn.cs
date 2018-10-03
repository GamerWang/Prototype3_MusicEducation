using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeColumn : MonoBehaviour {
    // editable properties
    public GameObject noteBottom;
    public GameObject noteBottomSlash;
    public GameObject noteTop;

    // public references & variables
    public float lineInterval { get; set; }
    public TrebleNoteType noteType { get; set; }

    // customize Initialization
    public void Init(float li = 25f, TrebleNoteType nt = TrebleNoteType.C4)
    {
        lineInterval = li;
        noteType = nt;

        GetComponent<RectTransform>().anchoredPosition = new Vector2(0, lineInterval * (int)noteType);

        noteBottom.SetActive(false);
        noteBottomSlash.SetActive(false);
        noteTop.SetActive(false);

        switch (noteType)
        {
            case TrebleNoteType.C4:
                noteBottomSlash.SetActive(true);
                break;
            case TrebleNoteType.D4:
            case TrebleNoteType.E4:
            case TrebleNoteType.F4:
            case TrebleNoteType.G4:
            case TrebleNoteType.A4:
                noteBottom.SetActive(true);
                break;
            case TrebleNoteType.B4:
            case TrebleNoteType.C5:
                noteTop.SetActive(true);
                break;
            default:
                break;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
