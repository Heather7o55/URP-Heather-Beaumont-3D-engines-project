using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor;
using UnityEngine;
public class Furnace : BaseInteractable
{
    private Item internalItem;
    //Interact is called every physics update, serving the same function for interactables as update does in other scripts
    public override void Interact(Collider col)
    {
        Debug.Log("Interacting");
        if(timerActive) return;
        if(!Input.GetKeyDown("Fire1")) return;
        if(ValidatePlayerItem(PlayerHolding.currentlyHeldItem.ID))
        {
            // Actually cool feature, Tuples let you switch values very easily
            (internalItem, PlayerHolding.currentlyHeldItem) = (PlayerHolding.currentlyHeldItem, internalItem);
        }
    }
}
