using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrebelManager : MonoBehaviour {
    // Singleton instance
    public static TrebelManager instance;

    // public references & variables
    public GameObject movingNote;
    // private references & variables
    bool isDraggingNote = false;
    
    // public functions
    public void StartNoteDrag()
    {
        if (!isDraggingNote)
        {
            isDraggingNote = true;
            // DEBUG
            SoundManager.instance.PlaySingleKey("C4");
            Debug.Log("TrebelManager: DragStart: " + Time.fixedTime);
        }
    }

    // timeline functions
    // Use this for initialization
    private void Awake()
    {
        instance = this;
    }

    void Start () {
        isDraggingNote = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (isDraggingNote && movingNote != null)
        {
            if (Input.touchCount > 0 || Input.GetMouseButton(0))
            {
                movingNote.SetActive(true);
            }
            else
            {
                isDraggingNote = false;
                movingNote.SetActive(false);
                // DEBUG
                SoundManager.instance.PlaySingleKey("C5");
                Debug.Log("TrebelManager: DragEnd: " + Time.fixedTime);
            }
        }
    }
}
