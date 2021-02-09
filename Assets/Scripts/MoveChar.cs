using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour
{
    public Transform[] BonusPos;
    int count = 0;

    public void Start()
    {
        StartCoroutine(Move());
    }

    
    
    IEnumerator Move()
    {
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1.5f);
        count++;
        yield return new WaitForSeconds(1.5f);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1.5f);
        count++;
        yield return new WaitForSeconds(1.5f);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1.5f);
        count++;
        yield return new WaitForSeconds(1.5f);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1.5f);
        count++;
        yield return new WaitForSeconds(1.5f);
        this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1.5f);
        count++;
        yield return new WaitForSeconds(1.5f); this.gameObject.transform.LookAt(BonusPos[count]);
        LeanTween.moveLocal(this.gameObject, BonusPos[count].position, 1.5f);
        count++;
        yield return new WaitForSeconds(1.5f);

    }
}
