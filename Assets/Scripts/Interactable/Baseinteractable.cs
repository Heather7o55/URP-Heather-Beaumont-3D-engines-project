using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Baseinteractable : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            if(Isbeinglookedat())
            {
                Interact();
            }
        }
    }
    bool Isbeinglookedat()
    {
        Ray Cameraray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(Cameraray, out RaycastHit hit))
        {
            if(hit.collider.gameObject == gameObject)
            {
                return true;
            }
            else{return false;}
        }
        else{return false;}
    }
    public abstract void Interact();
}
