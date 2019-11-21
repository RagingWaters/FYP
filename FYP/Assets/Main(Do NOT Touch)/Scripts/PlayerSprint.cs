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

    public PlayerControls playerControls;
    // private int currentSpeed;

    bool startCountdown = false;
    bool countDownActivated;
    public float currentCountTime;
    public float countDownTime;

    // Start is called before the first frame update
    void Start()
    {
        staminaSlider.maxValue = maxStamina;
        staminaSlider.value = maxStamina;

        // The higher the number, the slower the regen rate of the Stamina
        staminaFallRate = 0.5f;
        staminaRegenRate = 3f;

        countDownTime = 5f;
        currentCountTime = countDownTime;
        countDownActivated = false;

        //    playerControls = GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((playerControls.isMoving = true && Input.GetKey(KeyCode.LeftShift) && countDownActivated == false) || (playerControls.isMoving = true && Input.GetButton("Sprint") && countDownActivated == false))     // When player is moving and left shift is pressed, sprint is activated.
        {
            staminaSlider.value -= Time.deltaTime / staminaFallRate * staminaFallMult;
            playerControls.currentSpeed = playerControls.moveRunSpeed;
        }

        if (Input.GetButtonUp("Left Shift (Sprint)") || (staminaSlider.value == 0) || Input.GetButtonUp("Sprint"))
        {
            startCountdown = true;
            playerControls.currentSpeed = playerControls.moveSpeedNorm;
        }

        if (startCountdown == true)
        {
            countDownActivated = true;
            currentCountTime -= Time.deltaTime;
        }

        if (currentCountTime < 0)
        {
            startCountdown = false;
            currentCountTime = countDownTime;
            countDownActivated = false;
        }

        if (countDownActivated == false)
            staminaSlider.value += Time.deltaTime / staminaRegenRate * staminaRegenMult;

        if (staminaSlider.value >= maxStamina)
        {
            staminaSlider.value = maxStamina;
        }

        if (staminaSlider.value <= 0)
        {
            staminaSlider.value = 0;
        }
    }
}
