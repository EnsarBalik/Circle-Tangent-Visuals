using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangentCircles : CircleTangent
{
    public GameObject circlePrefab;
    private GameObject _innerCircleGo, _outterCircleGo;
    public Vector4 innerCircle, outerCircle;
    private Vector4[] _tangentCircle;
    private GameObject[] _tangentObjects;
    [Range(1, 64)] public int circleAmount;

    void Start()
    {
        _innerCircleGo = Instantiate(circlePrefab);
        _outterCircleGo = Instantiate(circlePrefab);

        _tangentCircle = new Vector4[circleAmount];
        _tangentObjects = new GameObject[circleAmount];

        for (int i = 0; i < circleAmount; i++)
        {
            GameObject tangentInstance = Instantiate(circlePrefab);
            _tangentObjects[i] = tangentInstance;
            _tangentObjects[i].transform.parent = transform;
        }
    }

    void Update()
    {
        _innerCircleGo.transform.position = new Vector3(innerCircle.x, innerCircle.y, innerCircle.z);
        _innerCircleGo.transform.localScale = new Vector3(innerCircle.w, innerCircle.w, innerCircle.w) * 2;

        _outterCircleGo.transform.position = new Vector3(outerCircle.x, outerCircle.y, outerCircle.z);
        _outterCircleGo.transform.localScale = new Vector3(outerCircle.w, outerCircle.w, outerCircle.w) * 2;

        for (int i = 0; i < circleAmount; i++)
        {
            _tangentCircle[i] = FindTangentCircle(outerCircle, innerCircle, (360f / circleAmount) * i);
            _tangentObjects[i].transform.position =
                new Vector3(_tangentCircle[i].x, _tangentCircle[i].y, _tangentCircle[i].z);
            _tangentObjects[i].transform.localScale =
                new Vector3(_tangentCircle[i].w, _tangentCircle[i].w, _tangentCircle[i].w) * 2;
        }
    }
}