using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class setStyle : MonoBehaviour
{
    public void setBallStyle() {
        string butID = EventSystem.current.currentSelectedGameObject.name;
        
        switch (butID) {
            case "1":
                PlayerPrefs.SetInt("ballStyle",1);
                SceneManager.LoadScene("startScreen");
                 break;
            case "2":
                PlayerPrefs.SetInt("ballStyle", 2);
                SceneManager.LoadScene("startScreen");
                break;
            case "3":
                PlayerPrefs.SetInt("ballStyle", 3);
                SceneManager.LoadScene("startScreen");
                break;
            case "4":
                PlayerPrefs.SetInt("ballStyle", 4);
                SceneManager.LoadScene("startScreen");
                break;
            case "5":
                PlayerPrefs.SetInt("ballStyle", 5);
                SceneManager.LoadScene("startScreen");
                break;
            case "6":
                PlayerPrefs.SetInt("ballStyle", 6);
                SceneManager.LoadScene("startScreen");
                break;
            case "7":
                PlayerPrefs.SetInt("ballStyle", 7);
                SceneManager.LoadScene("startScreen");
                break;
            case "8":
                PlayerPrefs.SetInt("ballStyle", 8);
                SceneManager.LoadScene("startScreen");
                break;
            case "9":
                PlayerPrefs.SetInt("ballStyle", 9);
                SceneManager.LoadScene("startScreen");
                break;
            case "10":
                PlayerPrefs.SetInt("ballStyle", 10);
                SceneManager.LoadScene("startScreen");
                break;
            case "11":
                PlayerPrefs.SetInt("ballStyle", 11);
                SceneManager.LoadScene("startScreen");
                break;
            case "12":
                PlayerPrefs.SetInt("ballStyle", 12);
                SceneManager.LoadScene("startScreen");
                break;
            case "13":
                PlayerPrefs.SetInt("ballStyle", 13);
                SceneManager.LoadScene("startScreen");
                break;
            case "14":
                PlayerPrefs.SetInt("ballStyle", 14);
                SceneManager.LoadScene("startScreen");
                break;
            case "15":
                PlayerPrefs.SetInt("ballStyle", 15);
                SceneManager.LoadScene("startScreen");
                break;
            case "16":
                PlayerPrefs.SetInt("ballStyle", 16);
                SceneManager.LoadScene("startScreen");
                break;
            case "17":
                PlayerPrefs.SetInt("ballStyle", 17);
                SceneManager.LoadScene("startScreen");
                break;
            case "18":
                PlayerPrefs.SetInt("ballStyle", 18);
                SceneManager.LoadScene("startScreen");
                break;
            case "19":
                PlayerPrefs.SetInt("ballStyle", 19);
                SceneManager.LoadScene("startScreen");
                break;
            case "20":
                PlayerPrefs.SetInt("ballStyle", 20);
                SceneManager.LoadScene("startScreen");
                break;
        }
        }
}

