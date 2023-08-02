using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;

    public AudioSource goFx;
    public AudioSource readyFx;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(2f);
        countDown3.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1f);
        countDown3.SetActive(false);
        countDown2.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(false);
        countDown1.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(false);
        countDownGo.SetActive(true);
        goFx.Play();
        PlayerMove.canMove = true;
    }
}
