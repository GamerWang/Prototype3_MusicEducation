using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeasureControl : MonoBehaviour {

    private Image main;
    public bool IsVisible;
    public bool check = true;

    SoundManager sound;


    public void start()
    {

        IsVisible = true;
        main = GetComponent<Image>();
        main.enabled = IsVisible;
    }

    private void OnEnable()
    {
        if (check)
        {
            sound = FindObjectOfType<SoundManager>();

            IsVisible = false;
            main = GetComponent<Image>();
            main.enabled = IsVisible;
            check = false;
        }
    }

    public void defaultPos()
    {
        main.rectTransform.anchoredPosition = new Vector2(-265, 241);
    }

    public void MoveBox2()
    {
        main.rectTransform.anchoredPosition = new Vector2(180,235);
    }

    public void MoveBox3()
    {
        main.rectTransform.anchoredPosition = new Vector2(-280, 38);
    }

    public void MoveBox4()
    {
        main.rectTransform.anchoredPosition = new Vector2(180, 38);
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
