using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEffects : MonoBehaviour {


    public Image Key, Treble_pos;

    public void ChangeColor()
    {
        Key.color = Color.green;
        Treble_pos.color = Color.black;
    }
    public void revertChangeColor()
    {
        Key.color = Color.white;
        Treble_pos.color = Color.white;
    }





    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
