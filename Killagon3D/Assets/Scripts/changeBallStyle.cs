using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBallStyle : MonoBehaviour
{
    public Material[] m;
    Renderer r;
    void Start()
    {
        r = GetComponent<Renderer>();
        int i = PlayerPrefs.GetInt("ballStyle");
        r.enabled = true;
        switch (i)
        {
            case 1:
                r.sharedMaterial = m[i-1];
                break;                
            case 2:                   
                r.sharedMaterial = m[i-1];
                break;                
            case 3:                   
                r.sharedMaterial = m[i-1];
                break;                
            case 4:                   
                r.sharedMaterial = m[i-1];
                break;                
            case 5:                   
                r.sharedMaterial = m[i-1];
                break;                
            case 6:                   
                r.sharedMaterial = m[i-1];
                break;                
            case 7:                   
                r.sharedMaterial = m[i-1];
                break;                
            case 8:                   
                r.sharedMaterial = m[i-1];
                break;                
            case 9:                   
                r.sharedMaterial = m[i-1];
                break;                
            case 10:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 11:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 12:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 13:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 14:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 15:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 16:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 17:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 18:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 19:                  
                r.sharedMaterial = m[i-1];
                break;                
            case 20:                  
                r.sharedMaterial = m[i-1];
                break;
        }

    }
}
