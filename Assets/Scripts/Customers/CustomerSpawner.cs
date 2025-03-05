using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
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
        Debug.Log("spawned customer");
        Instantiate(customerGObj, transform);
    }
}
