using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnClick : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }    
}
