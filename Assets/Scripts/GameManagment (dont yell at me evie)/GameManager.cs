using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
public static class GameManager
{
    // I do not want to do this, i understand it is bad practice, however this is the most feasible way to do this.
    public struct Request
    {
        public int timer;
        public Item item;
    }
    public static Request[] requests;
    public static void Pause()
    {
        // This is a shorthand if else statement
        Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
    }
    public static void CustomerRequest(Item request, int timer)
    {
        // unlike arrays .length counts like a human, so if there is nothing in the array it will return zero, this allows us to use it as a automatic plus 1 counter
        requests[requests.Length].item = request;
        requests[requests.Length].timer = timer;
    }
}