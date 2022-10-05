using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.PlayerMovement;

public class Stamina : MonoBehaviour
{
    public Slider staminaBar;

    private int maxStamina = 100;
    private float currentStamina;

    private WaitForSeconds regenTick = new WaitForSeconds(0.1f);
    private Coroutine regen;

    public static Stamina instance;

    public PlayerMovement player;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentStamina = maxStamina;
        staminaBar.maxValue = maxStamina;
        staminaBar.value = maxStamina;
    }

    void Update()
    {
        if (currentStamina > 40)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                useStamina(0.40f);
            }
            player.sprintSpeed = 6f;
            player.walkSpeed = 4f;
        }
        else if (currentStamina <= 40)
        {
            staminaBar.value = currentStamina;
            player.sprintSpeed = 4f;
            player.walkSpeed = 3f;
        }
    }

    public void useStamina(float amount)
    {
        if (currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            staminaBar.value = currentStamina;

            if (regen != null)
            {
                StopCoroutine(regen);
            }

            regen = StartCoroutine(RegenStamina());
        }
    }

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);

        while (currentStamina < maxStamina)
        {
            currentStamina += maxStamina / 100;
            staminaBar.value = currentStamina;
            yield return regenTick;
        }
    }
}

