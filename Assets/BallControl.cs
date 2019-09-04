using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	private Rigidbody2D rb2d;
    public GameObject Particle;

	void GoBall() {
        rb2d.AddForce(40 * Random.insideUnitCircle);
	}

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    void ResetBall() {
		rb2d.velocity = new Vector2 (0, 0);
		transform.position = Vector2.zero;
	}

	void RestartGame() {
		ResetBall ();
		Invoke ("GoBall", 1);
	}

	void OnCollisionEnter2D(Collision2D coll) {



        if (coll.collider.CompareTag("Player"))
        {
            GameObject clones = Instantiate(Particle, transform);
            clones.GetComponent<Rigidbody2D>().velocity = new Vector2(rb2d.velocity.x*2f, rb2d.velocity.y) + Random.insideUnitCircle;

            GameObject clone2 = Instantiate(Particle, transform);
            clone2.GetComponent<Rigidbody2D>().velocity = new Vector2(rb2d.velocity.x*3f, rb2d.velocity.y) + Random.insideUnitCircle;

            GameObject clone3 = Instantiate(Particle, transform);
            clone3.GetComponent<Rigidbody2D>().velocity = new Vector2(rb2d.velocity.x*1.4f, rb2d.velocity.y) + Random.insideUnitCircle;

            GameObject clone4 = Instantiate(Particle, transform);
            clone4.GetComponent<Rigidbody2D>().velocity = new Vector2(rb2d.velocity.x*2.4f, rb2d.velocity.y) + Random.insideUnitCircle;



            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f) + new Vector3(0f, transform.position.y - coll.transform.position.y, 0f).y;
            rb2d.velocity = vel;
        }


	}

}
