using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject other;
    [SerializeField] private Transform respawnPoint;
    //Vector3 trainPosition = new Vector3(0.2689247f, 2.700005f, 309.3f);

    void OnCollsionEnter()
    {
        Destroy(other);
        //StartCoroutine(Timer());
    }

    /*private IEnumerator Timer()
    {
        Destroy(other);
        other.transform.position = respawnPoint.transform.position;
        //yield return new WaitForSeconds(15);
        //Instantiate(respawn, Vector3(0.2689247f, 2.700005f, 309.3f), Quaternion.identity);
    }*/
}   
