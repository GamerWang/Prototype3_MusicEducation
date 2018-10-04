using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeModeStaffSpace : MonoBehaviour {
    // editable properties
    public GameObject staffImage;
    public FreeColumnWrapper freeColumnWrapper;

    // private references & variables
    float originalStaffImageOriginalWidth = 245f;
    float originalStaffImageHeight = 350f;
    float originalStaffLineInterval = 50f;
    float originalFirstLineFromBottom = 79f;

    // customize initialization
    public void Init()
    {
        // adjust all positions according to height of the staff image
        var imgRect = staffImage.GetComponent<RectTransform>();
        var h = imgRect.rect.height;
        var hScale = h / originalStaffImageHeight;
        var finalHeightOffset = hScale * (originalFirstLineFromBottom - originalStaffLineInterval);
        var finalLineInterval = hScale * originalStaffLineInterval / 2;

        freeColumnWrapper.Init(finalHeightOffset, finalLineInterval);
    }

	// Use this for initialization
	void Start () {
        // TEMP
        Init();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
