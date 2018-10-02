using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrebleNoteSpace : MonoBehaviour {
    // editable properties
    public GameObject noteColumnPrefab;

    public int _columnNumber = 5;

    public float _columnInterval = 100f;
    public Vector2 _columnOffset = new Vector2(230, 30);

    // public references & variables
    public List<GameObject> columnList { get; set; }

    // private references & variables

    // public functions
    public void GenerateColumns(int columnNumber)
    {
        if(columnList == null)
        {
            columnList = new List<GameObject>();
        }

        if(columnList.Count > 0)
        {
            foreach(var c in columnList)
            {
                Destroy(c);
            }
            columnList.Clear();
        }

        if(noteColumnPrefab != null)
        {
            for(var i = 0; i < columnNumber; i++)
            {
                var newColumn = Instantiate(noteColumnPrefab);
                newColumn.transform.SetParent(this.transform);
                newColumn.GetComponent<RectTransform>().anchoredPosition = new Vector2(i * _columnInterval, 0) + _columnOffset;

                var column = newColumn.GetComponent<NoteColumn>();
                column.Init(i);

                newColumn.SetActive(true);
            }
        }
    }

	// Use this for initialization
	void Start () {
        GenerateColumns(_columnNumber);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
