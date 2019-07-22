using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSprint : MonoBehaviour
{

    public Slider staminaSlider;
    public int maxStamina;
    private float staminaFallRate;
    public int staminaFallMult;
    private float staminaRegenRate;
    public int staminaRegenMult;

    PlayerControls playerControls;

    // Start is called before the first frame update
    void Start()
    {
        staminaSlider.maxValue = maxStamina;
        staminaSlider.value = maxStamina;

        // The higher the number, the slower the regen rate of the Stamina
        staminaFallRate = 0.5f;
        staminaRegenRate = 3;

        playerControls = GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {      
        if (playerControls.isMoving = true && Input.GetKey(KeyCode.LeftShift))
        {
            staminaSlider.value -= Time.deltaTime / staminaFallRate * staminaFallMult;
            playerControls.currentSpeed = playerControls.moveRunSpeed;
        }
        else
        {
            
            staminaSlider.value += Time.deltaTime / staminaRegenRate * staminaRegenMult;
            
        }

        if (staminaSlider.value >= maxStamina)
        {
            staminaSlider.value = maxStamina;
        }

        else if (staminaSlider.value <= 0)
        {
            staminaSlider.value = 0;
            playerControls.currentSpeed = playerControls.moveSpeedNorm;
        }

    }
}
