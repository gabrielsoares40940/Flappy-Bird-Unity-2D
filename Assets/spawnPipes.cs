using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipes : MonoBehaviour
{
    public GameObject pipes;
    public float height;
    public float maxTime = 1f;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipes);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipes);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 20f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
