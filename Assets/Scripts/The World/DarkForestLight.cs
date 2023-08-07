using UnityEngine;

public class DarkForestLight : MonoBehaviour
{
    public Light sun;
    public Light lantern;

    private void OnTriggerEnter(Collider other)
    {
        if (sun.intensity >= 1 && lantern.intensity <= 0)
        {
            sun.intensity = .5f;
            lantern.intensity = 1f;
        }
        else
        {
            sun.intensity = 1f;
            lantern.intensity = 0f;
        }
    }
}
