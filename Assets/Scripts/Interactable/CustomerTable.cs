using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CustomerTable : BaseInteractable
{
    private List<Item> internalItems = new List<Item>();
    public override void Interact(Collider col)
    {
        Debug.Log("Interacting");
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
        for(int i = 0; i < CustomerManager.requests.Count; i++)
        {
            for(int j = 0; j < internalItems.Count; j++)
            {
                if(CustomerManager.requests[i].item == internalItems[j])
                {
                    CustomerManager.requests.RemoveAt(i);
                    internalItems.RemoveAt(j);
                }
            }
        }
    }
}
