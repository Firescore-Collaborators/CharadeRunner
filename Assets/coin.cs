using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject Points;
    private void OnTriggerEnter(Collider other)
    {

        GameObject.Instantiate(Points, Points.transform.position, Points.transform.rotation);
        
        gameObject.SetActive(false);
    }
}
