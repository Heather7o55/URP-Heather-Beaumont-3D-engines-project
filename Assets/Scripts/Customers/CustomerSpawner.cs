using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject customerGObj;
    void Start()
    {
        SpawnCustomer();
    }
    public void SpawnCustomer()
    {
        Instantiate(customerGObj, transform);
    }
}
