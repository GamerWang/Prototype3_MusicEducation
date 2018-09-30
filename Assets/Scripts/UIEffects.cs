using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEffects : MonoBehaviour {


    public Image img;

    public void ChangeColor()
    {
        img.color = Color.yellow;
    }
    public void revertChangeColor()
    {
        img.color = Color.white;
    }





    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
