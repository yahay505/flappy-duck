using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float ScroolSpeed;
    public float TeleportPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * ScroolSpeed * Time.deltaTime;
        if (transform.position.x<=TeleportPoint)
        {
            Debug.Log("tped");
            transform.position=new Vector3(0, transform.position.y, transform.position.z);
        }
    }
}
