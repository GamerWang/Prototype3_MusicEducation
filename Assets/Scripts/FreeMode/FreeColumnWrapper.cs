using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeColumnWrapper : MonoBehaviour {
    // singleton instance
    public static FreeColumnWrapper instance;

    // editable properties
    public GameObject columnPrefab;
    public float columnInterval = 140;
    public int maxColumn = 7;

    // public references & variables
    public float hOffset { get; set; }
    public float lineInterval { get; set; }
    public List<FreeColumn> activeNoteList { get; set; }

    // private references & variables
    List<FreeColumn> notePool { get; set; }

    // private references & variables
    // public functions
    public void AddNewNote(TrebleNoteType type)
    {
        if(activeNoteList != null && type != TrebleNoteType._Default)
        {
            foreach(var n in activeNoteList)
            {
                n.GetComponent<RectTransform>().anchoredPosition += new Vector2(-columnInterval, 0);
            }
            if(activeNoteList.Count >= maxColumn)
            {
                var firstNote = activeNoteList[0];
                activeNoteList.RemoveAt(0);
                // TEMP
                Destroy(firstNote.gameObject);
            }

            var newColumn = Instantiate(columnPrefab);
            newColumn.transform.SetParent(transform);
            var column = newColumn.GetComponent<FreeColumn>();
            column.Init(lineInterval, type);

            newColumn.SetActive(true);
            activeNoteList.Add(column);
        }
    }

    public static void _AddNewNote(TrebleNoteType type)
    {
        instance.AddNewNote(type);
    }

    // customize initialization
    public void Init(float h = 29, float li = 25)
    {
        hOffset = h;
        lineInterval = li;

        var newPos = GetComponent<RectTransform>().anchoredPosition;
        newPos *= new Vector2(1, 0);
        newPos += new Vector2(0, h);
        GetComponent<RectTransform>().anchoredPosition = newPos;

        activeNoteList = new List<FreeColumn>();
        notePool = new List<FreeColumn>();
    }

    // Use this for initialization
    private void Awake()
    {
        instance = this;
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // TEMP
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddNewNote(TrebleNoteType.C4);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddNewNote(TrebleNoteType.C4);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AddNewNote(TrebleNoteType.D4);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            AddNewNote(TrebleNoteType.E4);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            AddNewNote(TrebleNoteType.F4);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            AddNewNote(TrebleNoteType.G4);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            AddNewNote(TrebleNoteType.A4);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            AddNewNote(TrebleNoteType.B4);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            AddNewNote(TrebleNoteType.C5);
        }
    }
}
