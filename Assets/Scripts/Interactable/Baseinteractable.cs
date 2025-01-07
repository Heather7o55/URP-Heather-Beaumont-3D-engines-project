using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Baseinteractable : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider col)
    {
        if(!col.CompareTag("Player")) {return;}
        if(!Isbeinglookedat()) {return;}
        Interact();
    }
    public bool Isbeinglookedat()
    {
        Ray Cameraray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(Cameraray, out RaycastHit hit))
        {
            return hit.collider.gameObject == gameObject;
        }
        else{return false;}
    }
    public abstract void Interact();
}
