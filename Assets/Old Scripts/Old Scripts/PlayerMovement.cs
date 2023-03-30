using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject TileLB;
    public GameObject TileLM;
    public GameObject TileLT;
    public GameObject TileMB;
    public GameObject TileMM;
    public GameObject TileMT;
    public GameObject TileRB;
    public GameObject TileRM;
    public GameObject TileRT;
    // public Vector3 test = new Vector3(GameObject.Find("TileTop").transform.position);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("w"))
        {

            Debug.Log("w works");

            //Left middle bottom
            if (this.transform.position == TileLB.transform.position)
            {
                Debug.Log("if entered");
                this.transform.position = TileLM.transform.position;
            }
            else if (this.transform.position == TileLM.transform.position)
            {
                Debug.Log("else if entered");
                this.transform.position = TileLT.transform.position;
            }
            //Middle middle bottom
            else if (this.transform.position == TileMB.transform.position)
            {
                Debug.Log("if entered");
                this.transform.position = TileMM.transform.position;
            }
            else if (this.transform.position == TileMM.transform.position)
            {
                Debug.Log("else if entered");
                this.transform.position = TileMT.transform.position;
            }
            //Right middle bottom
            else if (this.transform.position == TileRB.transform.position)
            {
                Debug.Log("if entered");
                this.transform.position = TileRM.transform.position;
            }
            else if (this.transform.position == TileRM.transform.position)
            {
                Debug.Log("else if entered");
                this.transform.position = TileRT.transform.position;
            }
        }

        if (Input.GetKeyDown("s"))
        {
            Debug.Log("s works");

            //Left top middle
            if (this.transform.position == TileLT.transform.position)
            {
                this.transform.position = TileLM.transform.position;
            }
            else if (this.transform.position == TileLM.transform.position)
            {
                this.transform.position = TileLB.transform.position;
            }
            //Middle top middle
            else if (this.transform.position == TileMT.transform.position)
            {
                this.transform.position = TileMM.transform.position;
            }
            else if (this.transform.position == TileMM.transform.position)
            {
                this.transform.position = TileMB.transform.position;
            }
            //Right top middle
            else if (this.transform.position == TileRT.transform.position)
            {
                this.transform.position = TileRM.transform.position;
            }
            else if (this.transform.position == TileRM.transform.position)
            {
                this.transform.position = TileRB.transform.position;
            }
        }

        if (Input.GetKeyDown("a"))
        {
            Debug.Log("a works");

            //Bottomrow middle right
            if(this.transform.position == TileMB.transform.position)
            {
                this.transform.position = TileLB.transform.position;
            }
            else if(this.transform.position == TileRB.transform.position)
            {
                this.transform.position = TileMB.transform.position;

            }

            //Middlerow middle right
            if (this.transform.position == TileMM.transform.position)
            {
                this.transform.position = TileLM.transform.position;
            }
            else if (this.transform.position == TileRM.transform.position)
            {
                this.transform.position = TileMM.transform.position;

            }

            //Toprow middle right
            if (this.transform.position == TileMT.transform.position)
            {
                this.transform.position = TileLT.transform.position;
            }
            else if (this.transform.position == TileRT.transform.position)
            {
                this.transform.position = TileMT.transform.position;

            }
        }

        if(Input.GetKeyDown("d"))
        {
            Debug.Log("d works");

            //Bottomrow middle left
            if (this.transform.position == TileLB.transform.position)
            {
                this.transform.position = TileMB.transform.position;
            }
            else if (this.transform.position == TileMB.transform.position)
            {
                this.transform.position = TileRB.transform.position;
            }

            //Middlerow middle left
            if (this.transform.position == TileLM.transform.position)
            {
                this.transform.position = TileMM.transform.position;
            }
            else if (this.transform.position == TileMM.transform.position)
            {
                this.transform.position = TileRM.transform.position;
            }

            //Toprow middle left
            if (this.transform.position == TileLT.transform.position)
            {
                this.transform.position = TileMT.transform.position;
            }
            else if (this.transform.position == TileMT.transform.position)
            {
                this.transform.position = TileRT.transform.position;
            }
        }



    }
}

//Debug.Log("w works");
//           this.transform.position = TileMiddle.transform.position;