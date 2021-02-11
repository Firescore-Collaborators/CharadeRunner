using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour
{
    public Transform[] BonusPos;
    int count = 0;
    public GameObject FiftyText;
    public ParticleSystem[] confetti;
    public void Start()
    {
        StartCoroutine(Move());
    }

    
    
    IEnumerator Move()
    {
        yield return new WaitForSeconds(0.5f);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1f);
        count++;
        yield return new WaitForSeconds(1f);

        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1f);
        yield return new WaitForSeconds(0.5f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.5f);


        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1f);
        yield return new WaitForSeconds(0.5f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.5f);


        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1f);
        yield return new WaitForSeconds(0.5f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.5f);

        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1f);
        yield return new WaitForSeconds(0.5f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.5f);

        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1f);
        yield return new WaitForSeconds(0.5f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.5f);
        ConfettiPlay();
    }
    public void ConfettiPlay()
    {
        foreach (ParticleSystem p in confetti)
        {
            p.Play();
        }
    }
}
