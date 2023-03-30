using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolderMovementScript : MonoBehaviour
{
    public EnemyMovement EnemyMovement;
    public float waitTime;
    private float timeStore;

    // Start is called before the first frame update
    void Start()
    {
        timeStore = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime > 0)
        {

            waitTime -= Time.deltaTime;
        }
        else
        {
            int rand = Random.Range(1, 100);
            if (rand > 50)
            {
                Debug.Log(">50");
                EnemyMovement.Up();
            }
            else
            {
                Debug.Log("<50");
                EnemyMovement.Down();
            }
            waitTime = timeStore;

        }
    }
}
