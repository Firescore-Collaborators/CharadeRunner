using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    Vector3 handpos;

    private void Awake()
    {
        handpos = Input.mousePosition;
        handpos.y = handpos.y - 25f;
        transform.position = handpos;
    }
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        handpos = Input.mousePosition;
        handpos.y = handpos.y - 25f;
        transform.position = handpos;
    }
}
