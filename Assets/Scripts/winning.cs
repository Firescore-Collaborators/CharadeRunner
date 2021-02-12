using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winning : MonoBehaviour
{
    public GameObject SkateBoard;
    public GameObject MainCAm;
    public GameObject WinCAm;
    public GameObject skate;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Win(other));
            
           
        }
    }

    IEnumerator Win(Collider other)
    {
        other.gameObject.GetComponent<Animator>().SetTrigger("jump");
        yield return new WaitForSeconds(0.7f);
        SkateBoard.SetActive(true);
        other.gameObject.SetActive(false);
        MainCAm.SetActive(false);
        WinCAm.SetActive(true);
        skate.SetActive(false);
    }
}
