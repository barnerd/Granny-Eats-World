using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signpost : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public string destinationName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider _other)
    {
        GameManager.instance.AddActiveSignpost(this);
    }

    public void OnInteract()
    {
        // Display UI list of teleport destinations
    }
}
