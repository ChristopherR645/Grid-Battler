using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDetectionScript : MonoBehaviour
{
    public Transform rayCasterTileDetection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Tile returnTile()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(rayCasterTileDetection.position, Vector3.back, 2);
        if (hitInfo != false)
        {
            Tile currentTile = hitInfo.collider.gameObject.GetComponent<Tile>();
            return currentTile;
        }
        return null;
    }
}
