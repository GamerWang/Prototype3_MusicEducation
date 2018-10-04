using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEffects : MonoBehaviour {


    public Image Key;
    public Sprite Up, Down;

    public void ChangeColor()
    {
        Key.sprite = Down;
    }
    public void revertChangeColor()
    {
        Key.sprite = Up;
    }





    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
