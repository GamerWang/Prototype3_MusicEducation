using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BaseNote : MonoBehaviour, IPointerDownHandler {
    // private functions
    void StartNoteDrag()
    {
        TrebelManager.instance.StartNoteDrag();
    }

    // event functions
    public void OnPointerDown(PointerEventData eventData)
    {
        StartNoteDrag();
    }

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
