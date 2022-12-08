
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//https://www.youtube.com/watch?v=BJzYGsMcy8Q&t=2s
//https://www.youtube.com/watch?v=ynh7b-AUSPE
//https://www.youtube.com/watch?v=oQ9877FdR8o
public class Player : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpSpeed;
    public float jumpButtonGracePeriod;

    private Animator animator;
    private CharacterController characterController;
    private float ySpeed;
    private float originalStepOffset;
    private float? lastGroundedTime;
    private float? jumpButtonPressedTime;

    [SerializeField]
    private Transform cameraTransform;

    public AudioClip impact;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * movementDirection;
        movementDirection.Normalize();

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (characterController.isGrounded)
        {
            lastGroundedTime = Time.time;
        }

        if (Input.GetButtonDown("Jump"))
        {
            audioSource.PlayOneShot(impact, 1F);
            jumpButtonPressedTime = Time.time;
            //Play jump animation
            animator.SetBool("isJumping",true);
            animator.SetBool("isRunning",false);
        }
         else
        {
                 animator.SetBool("isJumping",false);
        }

        if (Time.time - lastGroundedTime <= jumpButtonGracePeriod)
        {
            characterController.stepOffset = originalStepOffset;
            ySpeed = -0.5f;

            if (Time.time - jumpButtonPressedTime <= jumpButtonGracePeriod)
            {
                ySpeed = jumpSpeed;
                jumpButtonPressedTime = null;
                lastGroundedTime = null;
            }
        }
        else
        {
            characterController.stepOffset = 0;
        }

        Vector3 velocity = movementDirection * magnitude;
        velocity.y = ySpeed;

        characterController.Move(velocity * Time.deltaTime);

        if (movementDirection != Vector3.zero)
        {
           //play Running animation
            animator.SetBool("isRunning", true);
            animator.SetBool("isIdle",false);
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            //Play Idle animation
            animator.SetBool("isRunning", false);
            animator.SetBool("isIdle",true);
        }
    }
    private void OnApplicationFocus(bool focus) 
    {
        if (focus)
        {
            //Focus cursor disappears
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            //Unfocused cursor appears
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
    