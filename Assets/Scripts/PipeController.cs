using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float ScroolSpeed;
    public Collider2D scoreCollider,bird;
    public Collider2D[] DeathColliders;
    // Start is called before the first frame update
    void Start()
    {
        scoreCollider=transform.GetChild(2).GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * ScroolSpeed * Time.deltaTime;


        if (scoreCollider.IsTouching(bird))
        {
            scoreCollider.enabled = false;
            //GameManager.Manager.AddScore();
            Debug.Log("Score");
        }
        if (DeathColliders[0].IsTouching(bird)|| DeathColliders[1].IsTouching(bird)|| DeathColliders[2].IsTouching(bird))
        {
            DeathColliders[0].enabled = false;
            DeathColliders[1].enabled = false;
            DeathColliders[2].enabled = false;
            //GameManager.Manager.Die();
            Debug.Log("Death");
        }
    }
   
}
