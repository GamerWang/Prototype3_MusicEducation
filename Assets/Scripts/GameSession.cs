using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

   public int score = 0;
   public int level;
   public int measureLevel;

    public string Current_Key;
   private string[] keyCode = { " ", "C4", "C4", "G4", "G4", "A4", "A4", "G4", "F4", "F4", "E4", "E4", "D4", "D4", "C4" };

   public MeasureControl m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14;
    
	// Use this for initialization
	void Start () {

        Current_Key = null;
        measureLevel = 1;

        m1 = GameObject.Find("1C").GetComponent <MeasureControl> ();
        m2 = GameObject.Find("2C").GetComponent<MeasureControl>();
        m3 = GameObject.Find("3G").GetComponent<MeasureControl>();
        m4 = GameObject.Find("4G").GetComponent<MeasureControl>();
        m5 = GameObject.Find("5A").GetComponent<MeasureControl>();
        m6 = GameObject.Find("6A").GetComponent<MeasureControl>();
        m7 = GameObject.Find("7G").GetComponent<MeasureControl>();
        m8 = GameObject.Find("8F").GetComponent<MeasureControl>();
        m9 = GameObject.Find("9F").GetComponent<MeasureControl>();
        m10 = GameObject.Find("10E").GetComponent<MeasureControl>();
        m11 = GameObject.Find("11E").GetComponent<MeasureControl>();
        m12 = GameObject.Find("12D").GetComponent<MeasureControl>();
        m13 = GameObject.Find("13D").GetComponent<MeasureControl>();
        m14 = GameObject.Find("14C").GetComponent<MeasureControl>();

	}

    public void UpdateKey(string current)
    {
        Current_Key = current;
        Debug.Log("Level :" + level);
        Debug.Log("Measure Levle :" + measureLevel);
        Debug.Log("Current Key : " + Current_Key);

        //Controlling 1st Measure
        if (measureLevel == 1)
        {
            if (Current_Key == keyCode[1]) { m1.EnableNote(); measureLevel++; }
            else { m1.ShowError(); }
        }

        else if (measureLevel == 2)
        {
            if (Current_Key == keyCode[2]) { m2.EnableNote(); measureLevel++; }
            else { Failure(1); m2.ShowError(); measureLevel = 1; }
        }

        else if (measureLevel == 3)
        {
            if (Current_Key == keyCode[3]) { m3.EnableNote(); measureLevel++;  }
            else { Failure(1); m3.ShowError(); measureLevel = 1; }
        }

        else if (measureLevel == 4)
        {
            if (Current_Key == keyCode[4]) { m4.EnableNote(); measureLevel++; level++; }
            else { Failure(1); m4.ShowError(); measureLevel = 1; }
        }

        //Controlliong 2nd Measure
        else if (measureLevel == 5)
        {
            if (Current_Key == keyCode[5]) { m5.EnableNote(); measureLevel++; }
            else { m5.ShowError(); }
        }

        else if (measureLevel == 6)
        {
            if (Current_Key == keyCode[6]) { m6.EnableNote(); measureLevel++; }
            else { Failure(2); m6.ShowError(); measureLevel = 5; }
        }

        else if (measureLevel == 7)
        {
            if (Current_Key == keyCode[7]) { m7.EnableNote(); measureLevel++; level++; }
            else { Failure(2); m7.ShowError(); measureLevel = 5; }
        }

        //Controlling 3rd Measure

       else if (measureLevel == 8)
        {
            if (Current_Key == keyCode[8]) { m8.EnableNote(); measureLevel++; }
            else { m8.ShowError(); }
        }

        else if (measureLevel == 9)
        {
            if (Current_Key == keyCode[9]) { m9.EnableNote(); measureLevel++; }
            else { Failure(3); m9.ShowError(); measureLevel = 8; }
        }

        else if (measureLevel == 10)
        {
            if (Current_Key == keyCode[10]) { m10.EnableNote(); measureLevel++; }
            else { Failure(3); m10.ShowError(); measureLevel = 8; }
        }

        else if (measureLevel == 11)
        {
            if (Current_Key == keyCode[11]) { m11.EnableNote(); measureLevel++; level++; }
            else { Failure(3); m11.ShowError(); measureLevel = 8; }
        }

        //Controlliong 4th Measure
        else if (measureLevel == 12)
        {
            if (Current_Key == keyCode[12]) { m12.EnableNote(); measureLevel++; }
            else { m12.ShowError(); }
        }

        else if (measureLevel == 13)
        {
            if (Current_Key == keyCode[13]) { m13.EnableNote(); measureLevel++; }
            else { Failure(4); m13.ShowError(); measureLevel = 12; }
        }

        else if (measureLevel == 14)
        {
            if (Current_Key == keyCode[14]) { m14.EnableNote(); measureLevel++; level++; }
            else { Failure(4); m14.ShowError(); measureLevel = 12; }
        }

    }

    public void Failure(int lvl)
    {
        if (lvl == 1)
        {
            m1.DisableleNote();
            m2.DisableleNote();
            m3.DisableleNote();
            m4.DisableleNote();
        }
        if (lvl == 2)
        {
            m5.DisableleNote();
            m6.DisableleNote();
            m7.DisableleNote();
        }
        if (lvl == 3)
        {
            m8.DisableleNote();
            m9.DisableleNote();
            m10.DisableleNote();
            m11.DisableleNote();
        }
        if (lvl == 4)
        {
            m12.DisableleNote();
            m13.DisableleNote();
            m14.DisableleNote();
        }
    }
}
    
