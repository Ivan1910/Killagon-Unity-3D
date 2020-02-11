using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class home : MonoBehaviour
{
    
    public void goHome()
    {
        SceneManager.LoadScene("startScreen");
    }

    
}
