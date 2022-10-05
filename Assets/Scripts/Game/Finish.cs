using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Player")
        {
            GameManager.MyInstance.Finish();
        }
    }

    void OnTriggerExit(Collider Other)
    {
        if (Other.tag == "Player")
        {
            UIManager.MyInstance.HideVictoryCondition();
        }
    }
}
