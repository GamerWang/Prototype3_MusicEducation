using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugCanvas : MonoBehaviour {
    // singleton instance
    public static DebugCanvas instance;

    // editable properties
    public Text debugText;

    // public references & variables
    // public functions
    public static void _PrintText(string str)
    {
        instance.debugText.text += "\n";
        instance.debugText.text += str;
    }

    public void PrintText(string str)
    {
        debugText.text += "\n";
        debugText.text += str;
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
		
	}
}
