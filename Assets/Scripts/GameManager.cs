using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager;
    public int PipeCount, PipeSpace, FirstPipeOffset;
    public static int Score, HighScore;
    private void Awake()
    {
        if (Manager!=null&&Manager!=this)
        {
            Destroy(this.gameObject);
        }
        Manager = this;
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        StartSpawn(PipeCount, PipeSpace, FirstPipeOffset);  
    }
    void StartSpawn(int n,int _Space,int _offset)
    {
        for (int i = 1; i < n+1; i++)
        {
            Spawner.spawner.SpawnPipe(_offset + i * _Space);
        }
    }
    public void AddScore()
    {
        Score++;
        Spawner.spawner.SpawnPipe(FirstPipeOffset + PipeCount * PipeSpace);
        //UpdateUI();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
