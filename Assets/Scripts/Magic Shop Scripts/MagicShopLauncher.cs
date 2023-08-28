using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicShopLauncher : MonoBehaviour
{
    [SerializeField] MagicShop shop;
    bool isNearby;
    bool enteredShop = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isNearby)
        {
            if (Input.GetKeyDown(KeyCode.E) && !enteredShop)
            {
                shop.EnterShop();
                enteredShop = true;
            }
        }
    }
    
    public void LeaveShop() {
        enteredShop = false;
    }

    void OnTriggerEnter(Collider _other)
    {
        Debug.Log("Enter Magic Shop collider");
        isNearby = true;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit Magic Shop collider");
        isNearby = false;
    }
}
