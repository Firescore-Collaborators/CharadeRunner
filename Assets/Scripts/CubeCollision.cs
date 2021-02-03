using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public GameObject UIPanel;
    public GameObject TPPCamera;
    public GameObject FPPCamera;
    public GameObject Player;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIPanel.SetActive(true);
            Player.SetActive(true);
            other.gameObject.GetComponent<Animator>().enabled = false;
            TPPCamera.SetActive(false);
            FPPCamera.SetActive(true);
        }

    }

}
