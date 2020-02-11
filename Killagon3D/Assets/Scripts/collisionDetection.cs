using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collisionDetection : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Killagon")
        {
            SceneManager.LoadScene("endScene");
           
            // Debug.Log("killagon activated");
        }
        if (other.gameObject.name == "greenPoint")
        {
            string sceneName = SceneManager.GetActiveScene().name;
            switch (sceneName) {
                case "newGame":
                    if (1>PlayerPrefs.GetInt("highscore")) { PlayerPrefs.SetInt("highscore", 1);
                    }
                    SceneManager.LoadScene("level2");
                    break;
                case "level2":
                    if (2 > PlayerPrefs.GetInt("highscore"))
                    {PlayerPrefs.SetInt("highscore", 2);
                    }
                    SceneManager.LoadScene("level3");
                    break;
                case "level3":
                    if (3 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 3);
                    }
                    SceneManager.LoadScene("level4");
                    break;
                case "level4":
                    if (4 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 4);
                    }
                    SceneManager.LoadScene("level5");
                    break;
                case "level5":
                    if (5 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 5);
                    }
                    SceneManager.LoadScene("level6");
                    break;
                case "level6":
                    if (6 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 6);
                    }
                    SceneManager.LoadScene("level7");
                    break;
                case "level7":
                    if (7 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 7);
                    }
                    SceneManager.LoadScene("level8");
                    break;
                case "level8":
                    if (8 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 8);
                    }
                    SceneManager.LoadScene("level9");
                    break;
                case "level9":
                    if (9 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 9);
                    }
                    SceneManager.LoadScene("level10");
                    break;
                case "level10":
                    if (10 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 10);
                    }
                    SceneManager.LoadScene("level11");
                    break;
                case "level11":
                    if (11 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 11);
                    }
                    SceneManager.LoadScene("level12");
                    break;
                case "level12":
                    if (12 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 12);
                    }
                    SceneManager.LoadScene("level13");
                    break;
                case "level13":
                    if (13 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 13);
                    }
                    SceneManager.LoadScene("level14");
                    break;
                case "level14":
                    if (14 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 14);
                    }
                    SceneManager.LoadScene("level15");
                    break;
                case "level15":
                    if (15 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 15);
                    }
                    SceneManager.LoadScene("level16");
                    break;
                case "level16":
                    if (16 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 16);
                    }
                    SceneManager.LoadScene("level17");
                    break;
                case "level17":
                    if (17 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 17);
                    }
                    SceneManager.LoadScene("level18");
                    break;
                case "level18":
                    if (18 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 18);
                    }
                    SceneManager.LoadScene("level19");
                    break;
                case "level19":
                    if (19 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 19);
                    }
                    SceneManager.LoadScene("level20");
                    break;
                case "level20":
                    if (20 > PlayerPrefs.GetInt("highscore"))
                    {
                        PlayerPrefs.SetInt("highscore", 20);
                    }
                    SceneManager.LoadScene("congrats");
                    break;
            }
            
            // Debug.Log("greenPoint reached");
        }
    }
}
