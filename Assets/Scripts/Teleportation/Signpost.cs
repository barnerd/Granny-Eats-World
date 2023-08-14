using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FadeInOut))]
public class Signpost : MonoBehaviour
{
    public Transform destination;
    public string destinationName;
    public TeleportationUI teleportationUI;

    private bool isNearby;
    private Vector3 destinationPosition;

    void Awake()
    {
        isNearby = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isNearby)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (teleportationUI.IsActive)
                {
                    destinationPosition = teleportationUI.GetSelectedDestination();

                    // Hide UI
                    teleportationUI.SetActive(null, false);

                    if (destinationPosition != Vector3.zero)
                    {
                        // Fade In Out & Teleport
                        StartCoroutine(GetComponent<FadeInOut>().FadeOut(Teleport));
                    }
                }
                else
                {
                    teleportationUI.SetActive(this, true);
                }
            }
        }
    }

    public void Teleport()
    {
        // Teleport
        GameManager.instance.player.transform.position = destinationPosition;
    }

    void OnTriggerEnter(Collider _other)
    {
        GameManager.instance.AddActiveSignpost(this);
        isNearby = true;
    }

    void OnTriggerExit(Collider other)
    {
        isNearby = false;
    }
}
