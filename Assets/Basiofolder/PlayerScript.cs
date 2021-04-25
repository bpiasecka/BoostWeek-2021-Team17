using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed, jumpForce;
    public Rigidbody rb;
    public bool isGrounded, isJumpBlocked;
    public Vector3 startPositionInCar;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        SetStartPosition();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("walking", true);
            transform.eulerAngles = Vector3.zero;
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("walking", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else
            animator.SetBool("walking", false);

        if (!isJumpBlocked && isGrounded && Input.GetKey(KeyCode.W))
        {
            animator.SetBool("jumping", true);
            rb.AddForce(new Vector3(0f, jumpForce, 0f));
            StartCoroutine(BlockJump());
        }
        if(!isGrounded && Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0f, -jumpForce/2, 0f));
        }

        if(transform.position.y < 1f)
        {
            GameObject.FindObjectOfType<CarScript>().isDriving = false;
        }
    }
    public IEnumerator BlockJump()
    {   isJumpBlocked = true;
        yield return new WaitForSeconds(0.1f);
        isJumpBlocked = false;
    }
    public void SetGrounded(bool b)
    {
        if (b)
            animator.SetBool("jumping", false);
        isGrounded = b;
    }

    public void SetStartPosition()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("Car").transform);
        transform.localPosition = startPositionInCar;
    }
}