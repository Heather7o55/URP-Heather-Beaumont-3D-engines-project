using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
// I don't feel like this script is bad anymore, this is a perfectly reasonable script to make.
public class CustomerManager : MonoBehaviour
{
    // I declare valid items here as it makes sense to the requests for what items are valid be made here
    public static List<Item> validItems = new List<Item>();
    public static List<GameObject> orderUIList = new List<GameObject>();
    public struct Request
    {
        public float timer;
        public float timerActive;
        public Item item;
        public int requestID;
    }
    public static List<Request> requests = new List<Request>();
    public static void CustomerRequest(Request request)
    {
        requests.Add(request);
    }
    public static void ResetCustomerManager()
    {
        orderUIList.Clear();
        requests.Clear();
    }
}