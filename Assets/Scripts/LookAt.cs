using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Player;
    public Transform[] Positons;

    private void Start()
    {
        LeanTween.moveLocal(Player, Positons[0].position,5f);
    }


    public void RightAnswer()
    {
        Player.GetComponent<Animator>().SetTrigger("run");
        LeanTween.moveLocal(Player, Positons[1].position, 5f);
    }
}
