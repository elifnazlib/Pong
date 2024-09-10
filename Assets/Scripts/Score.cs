using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Inv. Walls Right") {
            RestartGame();
        }
        else if(other.gameObject.tag=="Inv. Walls Left") {
            RestartGame();
        }
    }
    void GoBall(){
        float rand = Random.Range(0, 2);
        if (rand < 1){
        rb2d.AddForce(new Vector2(200, -150));
        }
       else {
        rb2d.AddForce(new Vector2(-200, -150));
        }
    }
    void ResetBall(){
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }
}
