using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
// I don't feel like this script is bad anymore, this is a perfectly resonable script to make.
public static class CustomerManager
{
    // I declare valid items here as it makes sense to the requests for what items are valid be made here
    public static List<Item> validItems;
    public struct Request
    {
        public int timer;
        public Item item;
        public int requestID;
    }
    public static List<Request> requests;
    public static void CustomerRequest(Request request)
    {
        /* unlike arrays .length counts like a human, so if there is nothing in the array it will return zero, 
        this allows us to use it as a automatic plus 1 counter */
        requests[requests.Count] = request;
    }
}