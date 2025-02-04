using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CustomerTable : BaseInteractable
{
    private int oldListLength = 0;
    private List<Item> internalItems;
    public override void Interact(Collider col)
    {
        Debug.Log("Interacting");
    }
    void Update()
    {
        if(NewItem()) CheckValidItem();
    }
    private bool NewItem()
    {
        if(oldListLength < internalItems.Count) return true;
        else return false;
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
