using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class AttackerSpawner : MonoBehaviour
{
    private bool spawn = true;
    [SerializeField] private float spawnDelayMin = 1f;
    [SerializeField] private float spawnDelayMax = 5f;
    [SerializeField] private Attacker attackerPrefab;
    
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(spawnDelayMin, spawnDelayMax));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(
            attackerPrefab,
            transform.position,
            quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
