using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public float moveSpeed = 1f;

    void FixedUpdate() {

        Vector2 temp = transform.position;

        if(Input.GetAxis("Horizontal") > 0) {

            temp.x += moveSpeed * Time.deltaTime;
        
        } else if (Input.GetAxis("Horizontal") < 0) {

            temp.x -= moveSpeed * Time.deltaTime;

        }

        if (Input.GetAxis("Vertical") > 0) {

            temp.y += moveSpeed * Time.deltaTime;

        } else if (Input.GetAxis("Vertical") < 0) {

            temp.y -= moveSpeed * Time.deltaTime;

        }

        transform.position = temp;

    }

    void OnTriggerEnter2D(Collider2D target) {

        if(target.tag == "Enemy") {
            gameObject.SetActive(false);
            Invoke("RestartGame", 2f);
        }

        if (target.tag == "Goal") {
            NextLevel();
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
} // class































