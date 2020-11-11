using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator playerAnim;
    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetBool("iStrafe", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("iStrafe", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetTrigger("iAtk");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CubeBreak"))
        {
            playerAnim.SetTrigger("Death");
        }
    }
}
