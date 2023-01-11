using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CollectArea : MonoBehaviour
{
    public Stack stack;

    public int total;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stack.StackMoney(total);
        }
    }
}