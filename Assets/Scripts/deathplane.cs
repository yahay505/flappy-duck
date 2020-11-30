using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathplane : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Manager.Die();
    }
}
