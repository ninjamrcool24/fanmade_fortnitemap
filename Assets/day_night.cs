using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day_night : MonoBehaviour
{

    public Material day;
    public Material night;

    void Start()
    {
        RenderSettings.skybox = day;
    }
    void Update()
    {
        transform.Rotate(new Vector3(-3 * Time.deltaTime, 0, 0), Space.World);
        if (transform.rotation.x < -10 && transform.rotation.x > -170)
        {
            RenderSettings.skybox = night;
        }
        else{
            RenderSettings.skybox = day;
        }
    }
}
