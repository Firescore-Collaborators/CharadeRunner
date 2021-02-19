using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Player;
    public Transform[] Positons;
    public Transform TppCamPos;
    public Transform FailPos;
    public GameObject TPPCamera;
    public Animator[] Door;
    public Animator CorrectText;

    public ParticleSystem[] confetti;

    public List<GameObject> AICharacter;
   public AIDoors[] AIDoor;

    public static int count;

    private void Start()
    {
        count = 0;
        LeanTween.moveLocal(Player, Positons[count].position,3f);
        foreach (GameObject ai in AICharacter)
        {
            LeanTween.moveLocal(ai, new Vector3(ai.transform.position.x, ai.transform.position.y, Positons[count].position.z), 3f);
        }
        AICharacter.RemoveAt(AICharacter.Count-1);
    }




    public void RightAnswer()
    {

        StartCoroutine(Right());
    }


    IEnumerator Right()
    {

        ConfettiPlay();
        CorrectText.SetTrigger("text");
        yield return new WaitForSeconds(1f);
        OpenDoor();
        yield return new WaitForSeconds(2f);
        Player.GetComponent<Animator>().SetTrigger("run");
        LeanTween.moveLocal(Player, Positons[++count].position, 3f);
        if(AICharacter.Count > 0)
        {
            foreach (GameObject ai in AICharacter)
            {
                LeanTween.moveLocal(ai, new Vector3(ai.transform.position.x, ai.transform.position.y, Positons[count].position.z), Random.Range(2.5f, 4f));
            }

            AICharacter.RemoveAt(AICharacter.Count - 1);
        }
       
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

    public void OpenDoor()
    {
        foreach( GameObject door in AIDoor[count].Doors)
        {
           door.GetComponent<Animator>().SetTrigger("open");
        }
    }


    public void WrongAnswer()
    {

        StartCoroutine(Wrong());
    }


    IEnumerator Wrong()
    {
        LeanTween.moveLocal(Player, FailPos.position, 1f);
        Player.GetComponent<Animator>().SetTrigger("run");
        LeanTween.moveLocal(TPPCamera, TppCamPos.position, 1f);
        LeanTween.rotateLocal(TPPCamera, TppCamPos.rotation.eulerAngles, 1f);
        TPPCamera.GetComponent<CameraFollow>().enabled = true;
        yield return new WaitForSeconds(1f);
        Player.GetComponent<Animator>().applyRootMotion = enabled;
        Player.GetComponent<Animator>().SetTrigger("fall");
    }

}
