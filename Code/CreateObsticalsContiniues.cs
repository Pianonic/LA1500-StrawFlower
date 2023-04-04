using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CreateObsticalsContiniues : MonoBehaviour
{
    System.Random randN = new System.Random();
    int RandN = 0;
    int Counter = 0;
    int Zaxis = 10;

    void Update()
    {
        if (Counter < 5)
        {

            GameObject obstical = new GameObject("Obstical");
            GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            RandN = randN.Next(0, 3);

            if (RandN == 0)
            {
                cube1.transform.localScale = new Vector3(0f, 0f, 0f);
                cube2.transform.localScale = new Vector3(4f, 4f, 4f);
                cube3.transform.localScale = new Vector3(4f, 4f, 4f);
            }
            else if (RandN == 1)
            {
                cube1.transform.localScale = new Vector3(4f, 4f, 4f);
                cube2.transform.localScale = new Vector3(0f, 0f, 0f);
                cube3.transform.localScale = new Vector3(4f, 4f, 4f);
            }
            else if (RandN == 2)
            {
                cube1.transform.localScale = new Vector3(4f, 4f, 4f);
                cube2.transform.localScale = new Vector3(4f, 4f, 4f);
                cube3.transform.localScale = new Vector3(0f, 0f, 0f);
            }

            // Place into Parent
            cube1.transform.SetParent(obstical.transform);
            cube2.transform.SetParent(obstical.transform);
            cube3.transform.SetParent(obstical.transform);

            // Set Pos to 0 in Parent
            cube1.transform.position = new Vector3(0f, 2f, 0f);
            cube2.transform.position = new Vector3(4f, 2f, 0f);
            cube3.transform.position = new Vector3(-4f, 2f, 0f);

            // Load the Wood material from the Resources folder
            Material woodMaterial = Resources.Load<Material>("Wood");

            // Assign the Wood material to each cube
            cube1.GetComponent<Renderer>().material = woodMaterial;
            cube2.GetComponent<Renderer>().material = woodMaterial;
            cube3.GetComponent<Renderer>().material = woodMaterial;

            // Add components to game objects
            obstical.AddComponent<Movingplates>();
            cube1.GetComponent<BoxCollider>().isTrigger = true;
            cube2.GetComponent<BoxCollider>().isTrigger = true;
            cube3.GetComponent<BoxCollider>().isTrigger = true;

            cube1.AddComponent<Rigidbody>();
            cube2.AddComponent<Rigidbody>();
            cube3.AddComponent<Rigidbody>();

            cube1.GetComponent<Rigidbody>().useGravity = false;
            cube2.GetComponent<Rigidbody>().useGravity = false;
            cube3.GetComponent<Rigidbody>().useGravity = false;

            // Place obstical to other 
            obstical.transform.position = new Vector3(0f, 0f, Zaxis);

            // Set tags
            cube1.tag = "ObsticalTag";
            cube2.tag = "ObsticalTag";
            cube3.tag = "ObsticalTag";

            Zaxis += 20;
            Counter++;
            print(Counter);

        }
        
    }

}
