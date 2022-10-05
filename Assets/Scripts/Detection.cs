using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.Enemy;

public class Detection : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    public GameObject quizOneUI;
    public GameObject quizTwoUI;
    public GameObject quizThreeUI;
    public bool temp = false;

    //public Enemy enemy;

    UnityEngine.AI.NavMeshAgent agent;

    public static float speed = 6.0f;

    public static float counter = 1;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if (temp)
        {
            return;
        }
    }

    void OnTriggerEnter()
    {
        //player.transform.position = respawnPoint.transform.position;
        //enemy.isAngered = false;
        if (counter == 1)
        {
            temp = true;
            quizOneUI.SetActive(true);
            agent.speed = 0f;
            counter++;
        }
        else if (counter == 2)
        {
            temp = true;
            quizTwoUI.SetActive(true);
            agent.speed = 0f;
            counter++;
        }
        else if (counter == 3)
        {
            temp = true;
            quizThreeUI.SetActive(true);
            agent.speed = 0f;
            //counter++;
        }

    }

    void OnTriggerExit()
    {
        //player.transform.position = respawnPoint.transform.position;
        StartCoroutine(Pasue());
        //enemy.isAngered = true;
    }

    private IEnumerator Pasue()
    {
        yield return new WaitForSeconds(10);
        agent.speed = speed;
    }
}
