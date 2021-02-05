using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Player;
    public Transform[] Positons;
    public Transform TppCamPos;
    public GameObject TPPCamera;
    public Animator[] Door;

    public static int count;
    private void Start()
    {
        count = 0;
        LeanTween.moveLocal(Player, Positons[count].position,5f);
    }


    public void RightAnswer()
    {
        Player.GetComponent<Animator>().SetTrigger("run");
        Door[count].SetTrigger("open");
        LeanTween.moveLocal(Player, Positons[++count].position, 5f);
        LeanTween.moveLocal(TPPCamera, TppCamPos.position, 1f);
        LeanTween.rotateLocal(TPPCamera, TppCamPos.rotation.eulerAngles, 1f);
        TPPCamera.GetComponent<CameraFollow>().enabled = true;
        
    }


}
