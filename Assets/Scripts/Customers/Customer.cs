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
        // This just runs on start as we Instantiate the customer in a separate script so it can just make a request when its started
        CustomerManager.CustomerRequest(GetRequest());
    }
    /* Functions, or methods as they are called in class based languages, can have a return variable, 
    this return variable can be a custom defined variable, in this case my custom "request" struct*/
    private CustomerManager.Request GetRequest()
    {
        CustomerManager.Request request;
        // I use range here to pick a random number within the valid items list, which makes sure that customers can only request an item the player can make
        request.item = CustomerManager.validItems[Random.Range(0, CustomerManager.validItems.Count)];
        request.timer = Random.Range(DifficultyController.difficulty.low, DifficultyController.difficulty.high);
        while(true)
        {
            // this while loop makes sure that we don't get any duped IDs, i mean its unlikely anyway but for safety
            ID = Random.Range(0, 1000);
            if(!CustomerManager.requests.Any(Request => Request.requestID == ID)) break;
        }
        request.requestID = ID;
        return request;
    }
    private bool IfRequestFulfilled()
    {
        /* For those unaware, return returns the output of the given variable, 
        in this case since my return type is bool and the return type of that function call is also a bool i can just return the function, 
        as it returns the output of the function */
        return !CustomerManager.requests.Any(Request => Request.requestID == ID);
    }
    void Update()
    {
        /* We call this in update as running this next frame shouldn't pose any issues, 
        but running it on lateUpdate could cause it to run before CustomerTable's check making dupes possible */
        if(IfRequestFulfilled()) Destroy(gameObject);
    }
}
