using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class OrderUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Image green;
    public Image red;
    public CustomerManager.Request request;
    void Update()
    {
        if(green.fillAmount != 1f)
            green.fillAmount += 1.0f / request.timer * Time.deltaTime;
        else if(red.fillAmount != 1f) 
            red.fillAmount += 1.0f / request.timer * Time.deltaTime;
    }
}
