using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerTable : BaseInteractable
{
    // Start is called before the first frame update
    public override void Interact(Collider col)
    {
        Debug.Log("Interacting");
    }
}
