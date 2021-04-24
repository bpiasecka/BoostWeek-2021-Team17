using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed, jumpForce;
    public Rigidbody rb;
    public bool isGrounded, isJumpBlocked;
    public Vector3 startPositionInCar;
    // Start is called before the first frame update
    void Start()
    {
        SetStartPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (!isJumpBlocked && isGrounded && Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0f, jumpForce, 0f));
            StartCoroutine(BlockJump());
        }
    }
    public IEnumerator BlockJump()
    {
        isJumpBlocked = true;
        yield return new WaitForSeconds(0.1f);
        isJumpBlocked = false;
    }
    public void SetGrounded(bool b)
    {
        isGrounded = b;
    }

    public void SetStartPosition()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("Car").transform);
        transform.localPosition = startPositionInCar;
    }
}