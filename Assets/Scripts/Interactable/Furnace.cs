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
        if(timerActive) return;
        if(Input.GetKey(KeyCode.E))
        { 
            if(PlayerHolding.currentlyHeldItem == internalItem) return;
            if(ValidatePlayerItem(PlayerHolding.currentlyHeldItem))
                (PlayerHolding.currentlyHeldItem, internalItem) = (internalItem, PlayerHolding.currentlyHeldItem);
            else return;
        }
    }
    public void Update()
    {
        if(internalItem == empty || internalItem == sludge || !ValidatePlayerItem(internalItem)) return;
        if(timerActive) return;
        else 
        {
            internalItem = internalItem.nextState;
            StartCoroutine(StartTimer(interactableTimer));
        }
    }

}
