using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signpost : MonoBehaviour
{
    public Transform destination;
    public string destinationName;
    public TeleportationUI teleportationUI;

    private bool isNearby;

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
                    Vector3 destinationPosition = teleportationUI.GetSelectedDestination();

                    // Hide UI
                    teleportationUI.SetActive(null, false);

                    if (destinationPosition != Vector3.zero)
                    {
                        // Fade out
                        // Teleport
                        GameManager.instance.player.transform.position = destinationPosition;
                        // Fade in
                    }
                }
                else
                {
                    teleportationUI.SetActive(this, true);
                }
            }
        }
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
