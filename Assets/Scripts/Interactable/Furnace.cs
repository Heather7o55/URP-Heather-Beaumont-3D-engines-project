using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor;
using UnityEngine;
public class Furnace : BaseInteractable
{
    private Item internalItem;
    //Interact is called every physics update, serving the same function for interactables as update does in other scripts
    public void Start()
    {
        internalItem = empty;
    }
    public override void Interact(Collider col)
    {
        Debug.Log("Interacting");
        if(timerActive) return;
        if(Input.GetKey(KeyCode.E))
        { 
            if(PlayerHolding.currentlyHeldItem == internalItem) return;
            (PlayerHolding.currentlyHeldItem, internalItem) = (internalItem, PlayerHolding.currentlyHeldItem);
        }
    }
    public void Update()
    {
        if(internalItem == empty || internalItem == sludge || !ValidatePlayerItem(internalItem)) return;
        if(interactableTimer != 1) interactableTimer += 1f / internalItem.
    }
}
