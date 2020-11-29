using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager;
    public int PipeCount, PipeSpace, FirstPipeOffset;
    public static int Score, HighScore;
    public List<GameObject> PipeList;
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
            Debug.Log($"summoned{n}{_Space}{_offset}");
            PipeList.Add( Spawner.spawner.SpawnPipe(_offset + i * _Space));
        }
    }
    public void AddScore()
    {
        Score++;
        PipeList.Add(Spawner.spawner.SpawnPipe(FirstPipeOffset + PipeCount * PipeSpace));
        //UpdateUI();
    }
    // Update is called once per frame
    public void Die()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
        if (Time.timeScale==0&&Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject item in PipeList)
            {
                Destroy(item);
            }
            StartSpawn(PipeCount, PipeSpace, FirstPipeOffset);
            if (Score>HighScore)
            {
                HighScore = Score;
            }
            Score = 0;
            Time.timeScale = 1;
        }
        Debug.Log(PipeList.Count);
    }
}
