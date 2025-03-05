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
    public Image artwork;
    void Start()
    {
        artwork.sprite = request.item.artwork;  
    }
    void Update()
    {
        if(green.fillAmount != 1f)
            green.fillAmount += 1.0f / request.timer * Time.deltaTime;
        else if(red.fillAmount != 1f) 
            red.fillAmount += 1.0f / request.timer * Time.deltaTime;
        else
        {
            for(int i = 0; i < CustomerManager.requests.Count; i++)
            {
                if(CustomerManager.requests[i].requestID == request.requestID)
                {
                    CustomerManager.requests.RemoveAt(i);
                }
            }
        }
    }
}
