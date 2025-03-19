using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using Unity.VisualScripting;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    private bool timerActive = false;
    public GameObject customerGObj;
    void Start()
    {
        SpawnCustomer();
    }
    void Update()
    {
        if(timerActive) return;
        else
        {
            SpawnCustomer();
            StartCoroutine(StartTimer(RefreshTimer()));
        }
    }
    public void SpawnCustomer()
    {
        Debug.Log("spawned customer");
        Instantiate(customerGObj, transform);
    }
    private float RefreshTimer()
    {
        return Random.Range(DifficultyController.difficulty.low ,DifficultyController.difficulty.high) * 0.5f;
    }
    private IEnumerator StartTimer(float timer)
    {
        timerActive = true;
        yield return new WaitForSeconds(timer);
        timerActive = false;
    }
}
