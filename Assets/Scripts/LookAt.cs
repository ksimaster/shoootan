using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = GameObject.Find("Player1");
    }
    void Update()
    {
        gameObject.transform.LookAt(player.transform);
    }
}
