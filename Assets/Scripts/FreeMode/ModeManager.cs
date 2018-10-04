using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour {
    // singleton instance
    public static ModeManager instance;

    // editable variables
    public GameObject playMode;
    public GameObject freeMode;

    // private references & variables
    string mode { get; set; }

    // public functions
    public static void ToPlayMode()
    {
        instance.freeMode.SetActive(false);
        instance.playMode.SetActive(true);
        instance.mode = "Play";
    }

    public static void ToFreeMode()
    {
        instance.playMode.SetActive(false);
        instance.freeMode.SetActive(true);
        instance.mode = "Free";
    }

	// Use this for initialization
    void Awake()
    {
        instance = this;
    }

	void Start () {
        ToPlayMode();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // generate GUI
    private void OnGUI()
    {
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 40;
        

        if(GUI.Button(new Rect(Screen.width - 300, 50, 250, 150), "SwitchMode", myButtonStyle))
        {
            if(mode == "Play")
            {
                ToFreeMode();
            }else if(mode == "Free")
            {
                ToPlayMode();
            }
        }
    }
}
