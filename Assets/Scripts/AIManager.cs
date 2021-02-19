using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManager : MonoBehaviour
{
    public Transform[] position;
    public Animator[] Door;
    int count;

    private void Awake()
    {
        count = 0;
    }

    private void Start()
    {
        StartCoroutine(AIRun());
    }

    IEnumerator AIRun()
    {
        LeanTween.moveLocal(gameObject,new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,position[count].position.z),3f);
        
        yield return new WaitForSeconds(Random.Range(6f, 10f));
        Door[count].SetTrigger("open");
        count++;
        LeanTween.moveLocal(gameObject, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, position[count].position.z), 3f);
        yield return new WaitForSeconds(Random.Range(6f, 10f));
        Door[count].SetTrigger("open");
        count++;
        LeanTween.moveLocal(gameObject, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, position[count].position.z), 3f);
        yield return new WaitForSeconds(Random.Range(6f, 10f));
        Door[count].SetTrigger("open");
        count++;
        LeanTween.moveLocal(gameObject, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, position[count].position.z), 3f);
        yield return new WaitForSeconds(Random.Range(6f, 10f));
        Door[count].SetTrigger("open");
        count++;
    }
}
