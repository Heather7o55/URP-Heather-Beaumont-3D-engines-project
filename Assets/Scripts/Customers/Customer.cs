using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private int ID;
    void Start()
    {
        // This just runs on start as we Instanciate the customer in a seperate script so it can just make a request when its started
        CustomerManager.CustomerRequest(GetRequest());
    }
    CustomerManager.Request GetRequest()
    {
        CustomerManager.Request request;
        request.item = CustomerManager.validItems[Random.Range(0, CustomerManager.validItems.Count)];
        request.timer = Random.Range(DifficultyController.difficulty.low, DifficultyController.difficulty.high);
        while(true)
        {
            // this while loop makes sure that we dont get any duped IDs, i mean its unlikely anyway but for safety
            ID = Random.Range(0, 1000);
            if(!CustomerManager.requests.Any(Request => Request.requestID == ID)) break;
        }
        request.requestID = ID;
        return request;
    }
    bool IfRequestFufilled()
    {
        return !CustomerManager.requests.Any(Request => Request.requestID == ID);
    }
    void Update()
    {
        /* We call this in update as running this next fram shouldnt pose any issues, 
        but running it on lateUpdate could cause it to run before CustomerTable's check making dupes possible */
        if(IfRequestFufilled()) Destroy(gameObject);
    }
}
