using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackerSpawner : MonoBehaviour
{
    
   [SerializeField] float minSpawnerDelay = 1f;     
   [SerializeField] float maxSpawnerDelay = 5f;
   [SerializeField] Atacker attackerPrefab;
    
    bool spawn = true;
    
    IEnumerator Start()
    {
        while (spawn){
            yield return new WaitForSeconds(Random.Range(minSpawnerDelay,maxSpawnerDelay));
            SpawAttacker();
        }
       
    }
    private void SpawAttacker(){

        Instantiate(attackerPrefab,transform.position,transform.rotation);
    }
    void Update(){

    }
}
