using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    float speed = 100f;
    float horizontalMove = 0f;
    bool jump = false;
    private int oranges;

    public void Start(){
        oranges = 0;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }

        if (Input.GetKeyDown("r")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        

    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }

    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "Orange"){
            oranges++;
            other.gameObject.SetActive(false);
            Debug.Log(oranges);
            if (oranges == 4) {
            SceneManager.LoadScene("WinScreen");
            }
        }
    }
}
