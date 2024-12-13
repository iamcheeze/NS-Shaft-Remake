using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject block;
    public List<GameObject> blocks;

    public void SpawnBlock()
    {
        float randomNumber = Random.Range(-6.22f, 6.22f);
        int randomBlock = Random.Range(0, blocks.Count);
        Instantiate(blocks[randomBlock], new Vector3(randomNumber, -6.42f, 0), transform.rotation);
    }
}
