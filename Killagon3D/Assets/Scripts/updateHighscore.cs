using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class updateHighscore : MonoBehaviour
{
    private Text highscore;

    // Start is called before the first frame update
    void Start()
    {
        highscore = GetComponent<Text>();
        highscore.text = "HIGHSCORE:"+PlayerPrefs.GetInt("highscore",0).ToString();
    }

    // Update is called once per frame
  
}
