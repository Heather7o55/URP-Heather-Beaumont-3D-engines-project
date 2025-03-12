using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCrate : BaseInteractable
{
    public Item item;
    public override void Interact(Collider col)
    {
        Debug.Log("Interacting");
        if(Input.GetKey(KeyCode.E))
        {
            if(PlayerHolding.currentlyHeldItem != item) PlayerHolding.currentlyHeldItem = item;
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        CustomerManager.validItems.Add(item);
    }

}
