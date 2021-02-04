using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public GameObject UIPanel;
    public GameObject TPPCamera;
    public GameObject FPPCamera;
    public GameObject Player;
    public Animator PlayerAnim;
    public Transform PlayerPos;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIPanel.SetActive(true);
            Player.SetActive(true);
            other.gameObject.GetComponent<Animator>().SetTrigger("idle");
            LeanTween.moveLocal(TPPCamera, FPPCamera.gameObject.transform.position,0.5f);
            LeanTween.rotateLocal(TPPCamera, FPPCamera.gameObject.transform.rotation.eulerAngles, 0.5f);
            TPPCamera.GetComponent<CameraFollow>().enabled = false;
        }
    }

    public void RightAnswer()
    {
        PlayerAnim.SetTrigger("run");
        PlayerAnim.gameObject.transform.rotation = PlayerPos.rotation;
    }
}
