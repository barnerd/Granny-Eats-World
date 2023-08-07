using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenFly : MonoBehaviour
{
    [SerializeField] private GameObject fly;

    private bool isTop = true;

    //private Vector3 start = new Vector3(-143f, -40f, 0f);
    //private Vector credits = (-143f, -80f, 0f);

    void Start()
    {
        // fly.transform.Translate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isTop)
        {
            isTop = !isTop;
            fly.transform.Translate(0, 40, 0);
        }

        if (Input.GetKeyDown(KeyCode.S) && isTop)
        {
            isTop = !isTop;
            fly.transform.Translate(0, -40, 0);
        }

        if (isTop)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("START");
                SceneManager.LoadScene(1);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("CREDITS");
                SceneManager.LoadScene(3);
            }
        }
    }
}
