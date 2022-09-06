using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private float minMovementThreshold = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // player is moving to the left or right
        if (horizontalInput != 0)
        {
            Vector3 moveX = new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0f, 0f);
            transform.Translate(moveX);
        }

        // player is moving up or down
        if (verticalInput != 0)
        {
            Vector3 moveY = new Vector3(0f, verticalInput * moveSpeed * Time.deltaTime, 0f);
            transform.Translate(moveY);
        }
    }
}
