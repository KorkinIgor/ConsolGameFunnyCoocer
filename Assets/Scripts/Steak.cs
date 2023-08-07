using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : MonoBehaviour
{
    [SerializeField] private GameObject[] _Steaks;
    
    private void Start()
    {
        StartCoroutine(EnumeratorsteaksMoveBottom());
    }

    private void Update()
    {
        print(Povar.numberPovar);
    }

    private IEnumerator EnumeratorsteaksMoveBottom()
    {
        _Steaks[0].SetActive(true);
        yield return new WaitForSeconds(1);
        _Steaks[0].SetActive(false);
        _Steaks[1].SetActive(true);
        yield return new WaitForSeconds(1);
        _Steaks[1].SetActive(false);
        _Steaks[2].SetActive(true);
        yield return new WaitForSeconds(1);
        _Steaks[2].SetActive(false);
        _Steaks[3].SetActive(true);
        yield return new WaitForSeconds(1);
        _Steaks[3].SetActive(false);
        _Steaks[4].SetActive(true);
        yield return new WaitForSeconds(1);
        _Steaks[4].SetActive(true);
        if (Povar.numberPovar > 0)
        {
            _Steaks[4].SetActive(false);
            _Steaks[5].SetActive(true);
        }
        if (Povar.numberPovar == 0)
        {
            StopCoroutine(EnumeratorsteaksMoveBottom());
            StartCoroutine(EnumeratorsteaksMoveUp());
        }
    }

    private IEnumerator EnumeratorsteaksMoveUp()
    {
        _Steaks[3].SetActive(true);
        _Steaks[4].SetActive(false); 
        yield return new WaitForSeconds(1);
        _Steaks[2].SetActive(true);
        _Steaks[3].SetActive(false);
        yield return new WaitForSeconds(1);
        _Steaks[1].SetActive(true);
        _Steaks[2].SetActive(false);
        yield return new WaitForSeconds(1);
        _Steaks[0].SetActive(true);
        _Steaks[1].SetActive(false);
        yield return new WaitForSeconds(1);
        _Steaks[0].SetActive(false);
        StopCoroutine(EnumeratorsteaksMoveUp());
        StartCoroutine(EnumeratorsteaksMoveBottom());
    }
}




