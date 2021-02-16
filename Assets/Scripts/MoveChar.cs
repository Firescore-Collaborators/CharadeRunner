﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour
{
    public Transform[] BonusPos;
    int count = 0;
    public GameObject FiftyText;
    public Animator Player;
    public ParticleSystem[] confetti;
    public void Start()
    {
        StartCoroutine(Move());
    }

    
    IEnumerator Move()
    {
        //yield return new WaitForSeconds(0.4f);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 0.8f);
        count++;
        yield return new WaitForSeconds(0.8f);

        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 0.8f);
        yield return new WaitForSeconds(0.4f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.4f);


        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 0.8f);
        yield return new WaitForSeconds(0.4f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.4f);


        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 0.8f);
        yield return new WaitForSeconds(0.4f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.4f);

        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 0.8f);
        yield return new WaitForSeconds(0.4f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.4f);

        FiftyText.SetActive(true);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 0.8f);
        yield return new WaitForSeconds(0.4f);
        FiftyText.SetActive(false);
        count++;
        yield return new WaitForSeconds(0.4f);
        ConfettiPlay();
        Player.SetTrigger("dance");
    }
    public void ConfettiPlay()
    {
        foreach (ParticleSystem p in confetti)
        {
            p.Play();
        }
    }
}
