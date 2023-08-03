using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject mainCam;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        crashThud.Play();
        mainCam.GetComponent<Animator>().enabled = true;
    }
}
