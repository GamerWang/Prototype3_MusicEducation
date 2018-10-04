using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffects : MonoBehaviour {

    public Text measureText;

	// Use this for initialization
	void Start () {
       // measureText.color = Color.black;
	}

    public void windisable()
    {
        measureText.enabled = false;
    }

    public void WinEnable()
    {
        measureText.enabled = true;
    }

    public void changeColorText()
    {
        measureText.color = Color.blue;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
