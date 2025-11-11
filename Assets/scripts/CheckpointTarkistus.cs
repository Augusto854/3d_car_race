using UnityEngine;

public class CheckpointTarkistus : MonoBehaviour
{

    public int checkpointCount = 3;

    public bool[] visited;

    private int visitedCount;

    public int laps = 0; //mitä kierrosta ajetaan

    void Awake()
    {
        ResetLap();
    }

    public void ResetLap()
    {
        visited = new bool[checkpointCount];
        visitedCount = 0;
        laps++;
    }

    public void MarkVisited(int index)
    {
        if (!visited[index]) //= if (visited[index] == false)
        {
            visited[index] = true;
            visitedCount++;
        }
    }
    
    public bool CanWin()
    {
        if (checkpointCount == visitedCount)
        {
            return true;
        }
        return false;
    }
}