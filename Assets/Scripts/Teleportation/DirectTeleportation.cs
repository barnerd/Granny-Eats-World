using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FadeInOut))]
public class DirectTeleportation : MonoBehaviour
{
    public DirectTeleportation _other;

    void Start()
    {
        GameManager.instance.timeForNextTeleportation = Time.time;
    }

    public Vector3 TeleportDesination()
    {
        return _other.transform.position;
    }

    void OnTriggerEnter(Collider _other)
    {
        if (Time.time > GameManager.instance.timeForNextTeleportation)
        {
            GameManager.instance.timeForNextTeleportation = Time.time + 5f;

            // Fade In Out & Teleport
            StartCoroutine(GetComponent<FadeInOut>().FadeOut(Teleport));
        }
    }

    public void Teleport()
    {
        // Teleport
        GameManager.instance.player.transform.position = TeleportDesination();
    }
}
