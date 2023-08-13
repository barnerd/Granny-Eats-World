using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationUI : MonoBehaviour
{
    public GameObject panelUI;
    public GameObject destinationUIPrefab;
    public Transform destinationParent;

    private Signpost currentSignpost;

    public bool IsActive { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive)
        {
            DestinationUI[] _destinations = destinationParent.GetComponentsInChildren<DestinationUI>();
            if (Input.GetKeyDown(KeyCode.S))
            {
                // Select Next in list
                for (int i = _destinations.Length - 1; i >= 0; i--)
                {
                    if (_destinations[i].isSelected)
                    {
                        if (i + 1 != _destinations.Length)
                        {
                            _destinations[i].SetSelected(false);
                            _destinations[i + 1].SetSelected(true);
                        }
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                // Select Previous in list
                for (int i = 0; i < _destinations.Length; i++)
                {
                    if (_destinations[i].isSelected)
                    {
                        if (i != 0)
                        {
                            _destinations[i].SetSelected(false);
                            _destinations[i - 1].SetSelected(true);
                        }
                    }
                }
            }
        }
    }

    public void SetActive(Signpost _current, bool _active = true)
    {
        currentSignpost = _current;

        // Remove all previous destinations
        foreach (DestinationUI item in destinationParent.GetComponentsInChildren<DestinationUI>())
        {
            Destroy(item.gameObject);
        }

        if (_active)
        {
            // Generate list of DestinationUI
            foreach (Signpost signpost in GameManager.instance.ActiveSignposts)
            {
                if (signpost != _current)
                {
                    GameObject newUI = Instantiate(destinationUIPrefab, destinationParent);
                    newUI.GetComponent<DestinationUI>().SetSignpost(signpost);
                }
            }

            // Set first slot selected
            var destinations = destinationParent.GetComponentsInChildren<DestinationUI>();
            if (destinations.Length > 0)
            {
                destinations[0].SetSelected(true);
            }
        }

        // Show/Hide panel
        panelUI.SetActive(_active);
        IsActive = _active;
    }

    public Vector3 GetSelectedDestination()
    {
        foreach (DestinationUI item in destinationParent.GetComponentsInChildren<DestinationUI>())
        {
            if(item.isSelected)
            {
                return item.destination.destination.position;
            }
        }

        return Vector3.zero;
    }
}
