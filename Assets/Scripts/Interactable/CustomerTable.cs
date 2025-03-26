using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class CustomerTable : BaseInteractable
{
    private List<Item> internalItems = new List<Item>();
    public override void Interact(Collider col)
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(PlayerHolding.currentlyHeldItem == empty) return;
            internalItems.Add(PlayerHolding.currentlyHeldItem);
            PlayerHolding.currentlyHeldItem = empty;
        }
    }
    void LateUpdate()
    {
        // We run this in LateUpdate as it makes sure that all item transfers occur before this gets called
        CheckValidItem();
    }
    private void CheckValidItem()
    {
        int requestOverSoonest = 0;
        float timeleft = 0f;
        int item = -1;
        List<int> items = new List<int>();
        for(int i = 0; i < CustomerManager.requests.Count; i++)
        {
            for(int j = 0; j < internalItems.Count; j++)
            {
                if(CustomerManager.requests[i].item == internalItems[j])
                {   
                    if(item == -1) item = j;
                    if(item == j) items.Add(i);
                }
            }
        }
        for(int i = 0; i < items.Count; i++)
        {
            if(CustomerManager.requests[items[i]].timerActive >= timeleft)
            {
                timeleft = CustomerManager.requests[items[i]].timerActive;
                requestOverSoonest = items[i];
            } 
        }
        if(requestOverSoonest != 0)
        {
            CustomerManager.requests.RemoveAt(requestOverSoonest);
            internalItems.RemoveAt(item);
        }
        
    }
}
