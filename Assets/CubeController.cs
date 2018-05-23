using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private float speed = -0.2f;
    private float deadLine = -10;
    public AudioClip sound;


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        transform.Translate(this.speed, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
		
	}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "block" || other.gameObject.tag == "ground") 
        {
            GetComponent<AudioSource>().PlayOneShot(sound);
        }
    }
}
