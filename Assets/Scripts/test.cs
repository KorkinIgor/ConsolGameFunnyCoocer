using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void OnEnable()
    {
        Eventer.MyButton += PrintButtonName;
    }
    private void OnDisable()
    {
        Eventer.MyButton -= PrintButtonName;
    }

    private void PrintButtonName(string name)
    {
        print(name);
    }
    
}
