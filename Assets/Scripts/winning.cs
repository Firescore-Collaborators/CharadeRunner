using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winning : MonoBehaviour
{
    public GameObject SkateBoard;
    public GameObject MainCAm;
    public GameObject WinCAm;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SkateBoard.SetActive(true);
            other.gameObject.SetActive(false);
            MainCAm.SetActive(false);
            WinCAm.SetActive(true);
        }
    }
}
