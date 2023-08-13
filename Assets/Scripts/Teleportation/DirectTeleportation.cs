using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FadeInOut))]
public class DirectTeleportation : MonoBehaviour
{
    public DirectTeleportation _other;

    public Vector3 TeleportDesination()
    {
        return _other.transform.position;
    }

    void OnTriggerEnter(Collider _other)
    {
        // Fade In Out & Teleport
        StartCoroutine(GetComponent<FadeInOut>().FadeOut(Teleport));
    }

    public void Teleport()
    {
        // Teleport
        GameManager.instance.player.transform.position = TeleportDesination();
    }
}
