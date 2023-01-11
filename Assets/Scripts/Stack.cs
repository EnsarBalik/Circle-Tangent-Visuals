using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    public List<Transform> stackList;

    public GameObject money;
    public Transform stackTrans;

    public CollectArea collectArea;

    public void StackMoney(int addCount = 1)
    {
        for (int i = 0; i < addCount; i++)
        {
            if (collectArea.total <= 0) return;
            Transform spawnedObject = Instantiate(money, stackTrans).transform;
            collectArea.total--;

            if (stackList.Count <= 0)
            {
                spawnedObject.position = transform.position;
                stackList.Add(spawnedObject);
            }
            else
            {
                spawnedObject.localPosition = Vector3.up * (0.35f * stackList.Count);
                stackList.Add(spawnedObject);
            }
        }
    }
}