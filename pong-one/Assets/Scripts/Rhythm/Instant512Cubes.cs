using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant512Cubes : MonoBehaviour
{
    public GameObject Cubes;
    private GameObject[] allcubes = new GameObject[512];
    public float maxscale;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject cubeinstance = (GameObject)Instantiate(Cubes);
            cubeinstance.transform.position = this.transform.position;
            cubeinstance.transform.parent = this.transform;
            cubeinstance.name = "Sample: " + i;
            //this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            cubeinstance.transform.position = Vector3.up * 100;
            allcubes[i] = cubeinstance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int p = 0; p < 512; p++)
        {
            if (allcubes != null)
            {
                allcubes[p].transform.localScale = new Vector3(10, (AudioPeer.samples[p] * maxscale) + 2, 10);
            }
        }
    }
}
