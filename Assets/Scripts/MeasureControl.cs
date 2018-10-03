using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeasureControl : MonoBehaviour {

    private Image main;
    public bool IsVisible;

    SoundManager sound;

    private void OnEnable()
    {
        sound = FindObjectOfType<SoundManager>();

        IsVisible = false;
        main = GetComponent<Image>();
        main.enabled = IsVisible;

    }

    // Use this for initialization
    void Start () {
       
      
	}

    public void ShowError() {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        sound.PlayErrorClip();
        main.enabled = true;
        main.color = Color.red;

        yield return new WaitForSeconds(1);
        main.color = Color.white;
        main.enabled = false;
    }


    public void EnableNote()
    {
        IsVisible = true;
        main.enabled = IsVisible;
    }

    public void DisableleNote()
    {
        IsVisible = false;
        main.enabled = IsVisible;
    }

}
