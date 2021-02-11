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

    public List<GameObject> AICharacter;
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
        yield return new WaitForSeconds(3f);
        
        Player.GetComponent<Animator>().SetTrigger("run");
        Door[count].SetTrigger("open");
        LeanTween.moveLocal(Player, Positons[++count].position, 3f);
        if(AICharacter.Count > 0)
        {
            foreach (GameObject ai in AICharacter)
            {
                LeanTween.moveLocal(ai, new Vector3(ai.transform.position.x, ai.transform.position.y, Positons[count].position.z), 3f);
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

}
