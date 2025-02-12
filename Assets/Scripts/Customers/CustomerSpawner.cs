using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject customerGObj;
    public Transform spawnPoint;
    public void SpawnCustomer()
    {
        Instantiate(customerGObj, spawnPoint);
    }
}
