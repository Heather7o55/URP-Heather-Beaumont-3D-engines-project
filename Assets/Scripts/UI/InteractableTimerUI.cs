using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InteractableTimerUI : MonoBehaviour
{
    public static Image doing;
    public static Image green;
    public static Image red;
    public int screenPosition;
    public float waitTime = 10.0f;
    void Update()
    {

        doing.fillAmount += 1.0f / waitTime * Time.deltaTime;
        
        if(doing.fillAmount == 1.0f)
        {
            green.fillAmount += 1.0f / waitTime * Time.deltaTime;
        }
        if(green.fillAmount == 1.0f)
        {
            red.fillAmount += 1.0f / waitTime * Time.deltaTime;
        }
    }
}
