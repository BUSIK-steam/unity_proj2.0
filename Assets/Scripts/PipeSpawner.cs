using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] float timeToSpawn = 1f;
    [SerializeField] float borderTop = 0.8f;
    [SerializeField] float borderBottom = -0.2f;
    [SerializeField] GameObject pipes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartSpawning()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        while (true)
        {
            GameObject newPipe = Instantiate(pipes);
            Vector3 randomFactor = new Vector3(0,
                Random.Range(borderBottom, borderTop), 0);
            newPipe.transform.position = transform.position +
                randomFactor;
            Destroy(newPipe, 5f);
            yield return new WaitForSeconds(timeToSpawn);
        }
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
}
