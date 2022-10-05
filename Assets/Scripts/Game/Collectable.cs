using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Player")
        {
            Collected();
        }
    }

    protected virtual void Collected()
    {

    }
}
