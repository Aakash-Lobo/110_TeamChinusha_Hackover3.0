using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.Timer;

public class Helper : MonoBehaviour
{
    //[SerializeField] private Transform player;

    public GameObject helpUI;

    public static bool GameIsOver;

    //public Timer time;

    void Start()
    {
        GameIsOver = false;
        UnlockMouse();
    }

    void Update()
    {
        if (GameIsOver)
        {
            return;
        }
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void LockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Right()
    {
        Timer.timeValue += 20;
        helpUI.SetActive(false);
        //Destroy(this.gameObject);
        LockMouse();
    }

    public void Wrong()
    {
        Timer.timeValue -= 20;
        helpUI.SetActive(false);
        //Destroy(this.gameObject);
        LockMouse();
    }
}
