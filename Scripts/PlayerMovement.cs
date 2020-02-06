using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Text commandLog;

    public Rigidbody rb;                    // Declaring the RigidBody variable 'rb'

    public float forwardForce = 1000f;      // Variable for amount of forward force
    public float sidewaysForce = 500f;      // Variable for amount of sideways force
    public float jumpForce = 500f;


    void FixedUpdate ()                     // Using FixedUpdate() because we are using physics
    {
        // Add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Check if user is pressing the "up" key (either up arrow or 'w')
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            Command moveUp = new MoveUp(rb, jumpForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(moveUp);
            invoker.ExecuteCommand(moveUp);

            commandLog.text += "Move Up\n";
        }

        // Check if user is pressing the "right" key (either right arrow or 'd')
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            Command moveRight = new MoveRight(rb, sidewaysForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(moveRight);
            invoker.ExecuteCommand(moveRight);

            commandLog.text += "Move Right\n";
        }

        // Check if user is pressing the "left" key (either left arrow or 'a')
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            Command moveLeft = new MoveLeft(rb, sidewaysForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(moveLeft);
            invoker.ExecuteCommand(moveLeft);

            commandLog.text += "Move Left\n";
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
