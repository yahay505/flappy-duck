using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float ScroolSpeed,DeathX;
    public Collider2D scoreCollider,Bird;
    public Collider2D[] DeathColliders;
    // Start is called before the first frame update
    void Start()
    {
        scoreCollider=transform.GetChild(2).GetComponent<Collider2D>();
        DeathColliders[0] = transform.GetChild(0).GetComponent<Collider2D>();
        DeathColliders[1] = transform.GetChild(1).GetComponent<Collider2D>();
        DeathColliders[2] = transform.GetChild(3).GetComponent<Collider2D>();
        Bird = BirdController.Bird.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * ScroolSpeed * Time.deltaTime;


        if (scoreCollider.IsTouching(Bird))
        {
            scoreCollider.enabled = false;
            GameManager.Manager.AddScore();
            Debug.Log("Score");
        }
        if (DeathColliders[0].IsTouching(Bird)|| DeathColliders[1].IsTouching(Bird)|| DeathColliders[2].IsTouching(Bird))
        {
            DeathColliders[0].enabled = false;
            DeathColliders[1].enabled = false;
            DeathColliders[2].enabled = false;
            //GameManager.Manager.Die();
            Debug.Log("Death");
        }

        if (transform.position.x<=DeathX)
        {
            Destroy(this.gameObject);
        }
    }
   
}
