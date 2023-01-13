using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CollectArea : MonoBehaviour
{
    public Stack stack;
    public int total;

    public GameObject money;

    public float addInterval;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stack.StackMoney(total);
        }
    }

    private void Update()
    {
        //StackMoney();
    }

    public void StackMoney(int addCount = 1)
    {
        for (int i = 0; i < addCount; i++)
        {
            if (total <= 0) return;
            Transform spawnedObject = Instantiate(money).transform;
        }
    }
}