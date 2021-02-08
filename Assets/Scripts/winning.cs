using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winning : MonoBehaviour
{
    public GameObject SkateBoard;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SkateBoard.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
