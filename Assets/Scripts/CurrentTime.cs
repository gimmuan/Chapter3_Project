using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Data;

public class CurrentTime : MonoBehaviour
{
    [SerializeField] Text time1;

   
    // Update is called once per frame
    void Update()
    {
        time1.text = DateTime.Now.ToString("HH : mm : ss");
    }
}
