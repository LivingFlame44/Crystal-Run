using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float _maxTime;
    public float _heightRange;
    public GameObject[] obstacles;

    private float _timer = 0;
    // Start is called before the first frame update

    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnObstacle();
            _timer = 0;
        }
        _timer += Time.deltaTime;
            
    }

    private void SpawnObstacle()
    {
        GameObject obstacle = Instantiate(obstacles[Random.Range(0, obstacles.Length)]);
        obstacle.transform.position = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange), 0);
        Destroy(obstacle, 10);

    }
}
