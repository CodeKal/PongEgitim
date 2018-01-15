using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour {

	// Use this for initialization
    public float speed = 30;
    public Text ScoreRight, ScoreLeft; // Sağ ve Sol Skorları göstermek için metinler
    public int scoreLeft = 0, scoreRight = 0; //Başlangıç skorları

    void Start(){
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
     void Update(){
        ScoreLeft.text = ""+ scoreLeft; //ScoreLeft Metnini güncel skor ile güncelle
        ScoreRight.text = "" + scoreRight; //ScoreRight Metnini güncel skor ile güncelle

    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                    float racketHeight)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    void OnCollisionEnter2D(Collision2D col){
        // Note: 'col' holds the collision information. If the
        // Ball collided with a racket, then:
        //   col.gameObject is the racket
        //   col.transform.position is the racket's position
        //   col.collider is the racket's collider

        // Hit the left Racket?
        if (col.gameObject.name == "RacketLeft")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (col.gameObject.name == "WallLeft"){ //Sol Duvara vurursa sağ taraf puan alsın
            scoreRight += 1;
        }
        if (col.gameObject.name == "WallRight") //Sağ Duvara vurursa sağ taraf puan alsın
        {
            scoreLeft += 1;
        }


    }


	
}
