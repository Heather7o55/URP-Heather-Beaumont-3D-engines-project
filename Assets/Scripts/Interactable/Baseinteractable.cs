using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public abstract class BaseInteractable : MonoBehaviour
{
    public List<Item> validIDs;
    public float interactableTimer;
    public bool timerActive;
    private void OnTriggerStay(Collider col)
    {
        if(!col.CompareTag("Player")) return;
        // We do this because the triggers will be overlapping between interactables, this ensures the player can only interact with the one they're looking at
        if(!IsBeingLookedAt()) return;
        // We pass the collider through as it makes extra checks on the interactables script easier (and well possible lmao)
        Interact(col);
    }
    public bool IsBeingLookedAt()
    {
        Ray CameraRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(CameraRay, out RaycastHit hit))
            return hit.collider.gameObject == gameObject;
        else return false;
    }
    public bool ValidatePlayerItem(int ID)
    // We do this here as this is universally used across interactables
    {
        foreach(Item i in validIDs)    
        {
            if(ID == i.ID) return true;
        } return false;
    }
    public abstract void Interact(Collider col);
}
