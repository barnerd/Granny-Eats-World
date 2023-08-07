using UnityEngine;

public class EndDemo : MonoBehaviour
{
    private void OnTriggerEnter(Collider _other)
    {
        GameManager.instance.EndDemo();
    }
}
