using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Customer : MonoBehaviour
{
    void Update()
    {
        CustomerManager.CustomerRequest(GetRequest());
    }
    CustomerManager.Request GetRequest()
    {
        CustomerManager.Request request;
        request.item = CustomerManager.validItems[Random.Range(0, CustomerManager.validItems.Count)];
        request.timer = Random.Range(CustomerManager.difficulty.low, CustomerManager.difficulty.high);
        return request;
    }
}
