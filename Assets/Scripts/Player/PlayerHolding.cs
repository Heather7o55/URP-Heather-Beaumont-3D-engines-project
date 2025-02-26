using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHolding : MonoBehaviour
{
    public static Item currentlyHeldItem;
    public GameObject playerArm;
    public Transform spawnPoint;
    private GameObject heldItemObject;
    public Item empty;
    void Update()
    {
        if(currentlyHeldItem == empty) 
        {
            playerArm.SetActive(false);
            return;
        }
        playerArm.SetActive(true);
        if(!heldItemObject == currentlyHeldItem.model)
        {
            Destroy(heldItemObject);
            heldItemObject = Instantiate(currentlyHeldItem.model, spawnPoint);
        }
    }
}
