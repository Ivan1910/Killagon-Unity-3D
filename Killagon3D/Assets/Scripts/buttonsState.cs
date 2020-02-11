using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;



public class buttonsState : MonoBehaviour
{
    public Text t;
    public Button buttHandler;
    string butID;
    void Start()
    {
        butID = buttHandler.name;
        if (int.Parse(butID)<=PlayerPrefs.GetInt("highscore")) {
            buttHandler.interactable = true;
            t.text = "";
        }
    }

}
