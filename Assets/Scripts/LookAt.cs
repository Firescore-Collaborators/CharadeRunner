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
    public Animator CorrectText;
    public GameObject[] Hint;

    public ParticleSystem[] confetti;

    public static int count;
    private void Start()
    {
        count = 0;
        LeanTween.moveLocal(Player, Positons[count].position,3f);
    }




    public void RightAnswer()
    {

        StartCoroutine(Right());
    }


    IEnumerator Right()
    {
        ConfettiPlay();
        CorrectText.SetTrigger("text");
        yield return new WaitForSeconds(3f);
        Player.GetComponent<Animator>().SetTrigger("run");
        Door[count].SetTrigger("open");
        LeanTween.moveLocal(Player, Positons[++count].position, 3f);
        LeanTween.moveLocal(TPPCamera, TppCamPos.position, 1f);
        LeanTween.rotateLocal(TPPCamera, TppCamPos.rotation.eulerAngles, 1f);
        TPPCamera.GetComponent<CameraFollow>().enabled = true;
    }

    public void ConfettiPlay()
    {
        foreach (ParticleSystem p in confetti)
        {
            p.Play();
        }
    }

}
