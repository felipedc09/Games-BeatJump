using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    Player player;

    [SerializeField]
    Obstacle obstacle;

    List<Obstacle> obstacles;
    // Start is called before the first frame update
    void Start()
    {
        obstacles = new List<Obstacle>();
        for (var i = 0; i < 100; i++)
        {
            Obstacle newObstacle = Instantiate(obstacle, obstacle.transform.parent);
            obstacles.Add(newObstacle);
            if (i != 0)
            {
                float newPosition = obstacles[i - 1].transform.localPosition.x + 1;
                newObstacle.transform.Translate(Vector3.right * newPosition);
            }
        }
        obstacle.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
