using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float distanceToMove = 4f;

    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    void AnimatePlayer(float horizontalInput, float verticalInput)
    {
        // perform walking animation (x dir)
        playerAnim.SetFloat("moveSpeedX", horizontalInput);
        // perform walking animation (y dir)
        playerAnim.SetFloat("moveSpeedY", verticalInput);
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // player is moving left or right
        if (horizontalInput != 0)
        {
            Vector3 moveX = new Vector3(horizontalInput * playerSpeed * Time.deltaTime, 0f, 0f);
            transform.Translate(moveX);
            // determine if player is/was facing right
            playerAnim.SetBool("isFacingRight", horizontalInput > 0);
        }

        // player is moving up or down
        if (verticalInput != 0)
        {
            Vector3 moveY = new Vector3(0f, verticalInput * playerSpeed * Time.deltaTime, 0f);
            transform.Translate(moveY);
        }

        AnimatePlayer(horizontalInput, verticalInput);
        
        // check if the Y button was pressed
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Vector3 teleportPosition = transform.position + Vector3.left * distanceToMove;
            transform.position = teleportPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
}
