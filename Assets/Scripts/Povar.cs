using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Povar : MonoBehaviour
{
    [SerializeField] private GameObject[] picturePovar;
    private int numberPovar = 0;
    
    private void OnEnable()
    {
        Eventer.MyButton += ChangePositionPovar;
    }
    private void OnDisable()
    {
        Eventer.MyButton -= ChangePositionPovar;
    }
   private void Start()
    {
        picturePovar[0].SetActive(true);
        for (var i = 1; i < picturePovar.LongLength; i++)
        {
           picturePovar[i].SetActive(false); 
        }
    }

   private void ChangePositionPovar(string a)
   {
       if (a == "right_button")
       {
           if (numberPovar < 3)
           {
               numberPovar++;
               print(numberPovar);
               for (var i = 0; i < picturePovar.LongLength; i++)
               {
                   picturePovar[i].SetActive(false);
               }

               picturePovar[numberPovar].SetActive(true);
           }
       }

       if (a == "left_button")
       {
           if (numberPovar > 0)
           {
               numberPovar--;
               for (var i = 0; i < picturePovar.LongLength; i++)
               {
                   picturePovar[i].SetActive(false);
               }

               picturePovar[numberPovar].SetActive(true);
           }
       }

   }

    
}
