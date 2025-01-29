using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
public static class CustomerManager
{
    public static Item[] validItems;
    // I do not want to do this, i understand it is bad practice, however this is the most feasible way to do this.
    public struct Request
    {
        public int timer;
        public Item item;
    }
    public struct Difficulty
    {
        public int low;
        public int high;
    }
    public static Difficulty difficulty;
    public static Request[] requests;
    public static void CustomerRequest(Request request)
    {
        // unlike arrays .length counts like a human, so if there is nothing in the array it will return zero, this allows us to use it as a automatic plus 1 counter
        requests[requests.Length] = request;
    }
}