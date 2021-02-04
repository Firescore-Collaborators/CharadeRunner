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
            LeanTween.moveLocal(TPPCamera, FPPCamera.gameObject.transform.position,1f);
            LeanTween.rotateLocal(TPPCamera, FPPCamera.gameObject.transform.rotation.eulerAngles, 1f);
            TPPCamera.GetComponent<CameraFollow>().enabled = false;
        }

    }

}
