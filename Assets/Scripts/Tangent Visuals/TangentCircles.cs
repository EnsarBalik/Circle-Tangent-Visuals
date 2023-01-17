using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangentCircles : CircleTangent
{
    public GameObject circlePrefab;
    private GameObject _innerCircleGo, _outterCircleGo,_tangentCircleGo;
    public Vector4 innerCircle, outerCircle;
    public float tangentCircleRadius;
    public float degree;

    void Start()
    {
        _innerCircleGo = Instantiate(circlePrefab);
        _outterCircleGo = Instantiate(circlePrefab);
        _tangentCircleGo = Instantiate(circlePrefab);
    }

    void Update()
    {
        _innerCircleGo.transform.position = new Vector3(innerCircle.x, innerCircle.y, innerCircle.z);
        _innerCircleGo.transform.localScale = new Vector3(innerCircle.w, innerCircle.w, innerCircle.w) * 2;
        
        _outterCircleGo.transform.position = new Vector3(outerCircle.x, outerCircle.y, outerCircle.z);
        _outterCircleGo.transform.localScale = new Vector3(outerCircle.w, outerCircle.w, outerCircle.w) * 2;

        _tangentCircleGo.transform.position =
            GetRotatedTangent(degree, outerCircle.w) + _outterCircleGo.transform.position;
        _tangentCircleGo.transform.localScale =
            new Vector3(tangentCircleRadius, tangentCircleRadius, tangentCircleRadius) * 2;
    }
}