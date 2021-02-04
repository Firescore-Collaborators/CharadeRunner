using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Player;
    public Transform[] Positons;
    public Transform TppCamPos;
    public GameObject TPPCamera;

    private void Start()
    {
        LeanTween.moveLocal(Player, Positons[0].position,5f);
    }


    public void RightAnswer()
    {
        Player.GetComponent<Animator>().SetTrigger("run");
        LeanTween.moveLocal(Player, Positons[1].position, 5f);
        LeanTween.moveLocal(TPPCamera, TppCamPos.position, 1f);
        LeanTween.rotateLocal(TPPCamera, TppCamPos.rotation.eulerAngles, 1f);
        TPPCamera.GetComponent<CameraFollow>().enabled = true;
    }


}
