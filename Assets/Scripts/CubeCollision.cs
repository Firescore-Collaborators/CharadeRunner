using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public GameObject[] UIPanel;
    public GameObject TPPCamera;
    public GameObject FPPCamera;
    public GameObject Player;
    public GameObject Hand;
    public Animator PlayerAnim;
    public Transform PlayerPos;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Hand.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(collionDetect(other));
            
           
        }
    }

    IEnumerator collionDetect(Collider other)
    {
        Player.SetActive(true);
        other.gameObject.GetComponent<Animator>().SetTrigger("idle");
        LeanTween.moveLocal(TPPCamera, FPPCamera.gameObject.transform.position, 0.5f);
        LeanTween.rotateLocal(TPPCamera, FPPCamera.gameObject.transform.rotation.eulerAngles, 0.5f);
        TPPCamera.GetComponent<CameraFollow>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        UIPanel[CharacterManager.count].SetActive(true);
        
    }
}
