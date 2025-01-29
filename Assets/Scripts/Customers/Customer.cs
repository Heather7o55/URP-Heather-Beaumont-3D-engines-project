using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Customer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is tmp, i need more complex code here i made this is the last couple of minutes of class >.>
        CustomerManager.CustomerRequest(GetRequest());
    }
    CustomerManager.Request GetRequest()
    {
        CustomerManager.Request request;
        request.item = CustomerManager.validItems[Random.Range(0, CustomerManager.validItems.Length)];
        request.timer = Random.Range(CustomerManager.difficulty.low, CustomerManager.difficulty.high);
        return request;
    }
}
