using UnityEngine;

public class GingerbreadMan : MonoBehaviour
{
    [SerializeField] public Animator gingerBread;

    public void gingerbreadRun()
    {
        gingerBread.SetTrigger("RUN!");
    }
}
