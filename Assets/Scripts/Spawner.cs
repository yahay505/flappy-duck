using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner spawner;
    public GameObject PipePrefab;
    public float RNGrange;
    // Start is called before the first frame update
    private void Awake()
    {
        spawner = this;
    }
    // Update is called once per frame
    public void SpawnPipe(float x)
    {
        Instantiate(PipePrefab, new Vector3(x, Random.Range(RNGrange * -1, RNGrange), 1),transform.rotation);

    }

}
